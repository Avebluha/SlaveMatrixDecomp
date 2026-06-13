# SlaveMatrix Engine Rewrite Plan

## Goal

Rearchitect the game from a decompiled monolith with hardcoded Japanese string lookups, BinaryFormatter resources, and GDI+ rendering into a moddable, data-driven engine with Vulkan/Silk.NET rendering, YAML sidecar definitions, and SVG vector assets.

## Key Decisions

- **Clean break** from save compatibility (no BinaryFormatter/RenameMap)
- **Vulkan/Silk.NET** rendering backend
- **YAML** sidecar data files for body part definitions
- **Full modding support**: new body parts, races, color schemes, animation states
- **SVG extraction** for vector graphics data; Vulkan rendering at runtime
- **Runtime catalog** built from sidecar files at load time
- **No MigrateKeys** -- resource data will have keys renamed at extraction time, not at runtime

## Current State

- 843 BodyPartClasses with Japanese filenames
- 13 binary `Obj` resources embedded in `.resx` (5.5MB largest)
- `MigrateKeys()` runtime key-mutation for 4 of 13 resources (fragile, incomplete)
- 1,660 unique string keys across all resource lookups
- BinaryFormatter double-wrapped serialization
- GDI+ rendering with cardinal splines, GraphicsPath, hit-testing
- Existing `Ser.ToJson`/`Ser.UnJson` infrastructure (needs fixes for private fields and OrderedDictionary)

## Phase 0: Resource Extraction & Asset Pipeline

### 0.1: Fix JSON Serialization

- Add `JsonConverter<OrderedDictionary<T1,T2>>` for proper dictionary round-tripping
- Configure `DefaultContractResolver` to include private fields (`Difs.difs`, `Dif.parss`, `Pars.parent`)
- Fix `ToJsonBytes` to use `PreserveReferencesHandling.All` (match `ToJson`)
- Test: `ObjLoad()` -> `ToJson()` -> `UnJson()` -> verify rendering is identical

### 0.2: Build Complete Key Map

- Audit ALL `Sta.X["key"]` and `pars["key"]` lookups across all body part classes
- Build definitive `KeyMap` covering all 155 top-level keys + 1,516 Pars keys
- Add Pars-level recursive migration to `MigrateKeys()`
- Apply `MigrateKeys()` to ALL 13 resources (currently only 4 get it)

### 0.3: Write Extraction Console App

- Create `SlaveMatrix.Extract` console project
- Load all 13 `Obj` from embedded resources
- Apply complete `MigrateKeys()`
- Export each `Obj` to JSON file
- Export body part breakdown (each `Difs` key -> separate file)
- For SVG export: iterate all `Par` objects, convert cardinal spline to cubic Bezier, write SVG `<path>` elements
- Export part metadata (joints, connections, color data) as YAML sidecar files
- Output a catalog of all parts with their connections

### 0.4: Validate Extraction

- Build visual comparison tool: render original vs. extracted -> pixel diff
- Verify all keys match, all shapes present, all morph variants accounted for

## Phase 1: Engine Foundation

- New .NET 8 solution: `SlaveMatrix.Engine`, `SlaveMatrix.Modding`, `SlaveMatrix.Game`, `SlaveMatrix.AssetTool`
- Vulkan/Silk.NET renderer: GPU path rendering, fill/stroke, hit-testing
- YAML part definition schema (connections, variants, colors, joints)
- Asset loader: scan `Assets/` directories, build runtime `PartCatalog`
- Morph interpolation between SVG variants

## Phase 2: Character Assembly & Joints

- Explicit joint definitions in YAML (no proximity-based matching)
- Connection resolution: parent-child graph from catalog
- Character builder: given race template, assemble character from parts
- Runtime catalog on startup

## Phase 3: Game Logic Migration

- YAML-based character saves (replace EleD serialization)
- YAML-driven color palette system (replace `配色指定`/`BodyColorSet`)
- Pose/animation system (same morph concept, YAML-defined)
- Port UI

## Phase 4: Modding API

- Mod package format: manifest.yaml + Parts/ + Races/ + Colors/
- Mod loader: merge catalogs, validate connections
- Hot reload during development

## Phase 5: Polish & Release

- Build pipeline: MSBuild targets for asset packing
- Performance: GPU instancing, spatial partitioning
- Visual regression tests

## Resource Architecture

### Current (Binary)

```
Resources.resx -> byte[] -> BinaryFormatter(BinaryFormatter(Obj)) -> Obj
                     Obj.Difss keys are Japanese
                     MigrateKeys() renames some keys at runtime (fragile)
```

### Target (YAML + SVG)

```
Assets/
  Parts/torso/torso.yaml         <- part definition
  Parts/torso/torso_base.svg      <- X0Y0 variant
  Parts/torso/torso_morph1.svg    <- X1Y0 variant
  Colors/skin_tones.yaml          <- color palette
  Races/human.yaml                <- race template
  Catalog.yaml                    <- auto-generated index

Game loads YAML+SVG at runtime, no embedded binary resources needed.
Modders add directories under Assets/Parts/ to add new parts.
```

## Rendering Architecture

### Current (GDI+)

- `System.Drawing.Graphics.FillPath/DrawPath` for fills and strokes
- `GraphicsPath.AddCurve(points, tension)` for cardinal splines
- Separate hit-test pass with unique colors per `Par`
- `Difs.ValueX/ValueY` controls morph interpolation (discrete variant selection)

### Target (Vulkan/Silk.NET)

- GPU path rendering: tessellate cubic Bezier curves into triangles
- Separate hit-test pass: render with unique colors to offscreen buffer, read pixel
- Morph interpolation: blend control point positions between SVG variants
- YAML-driven pose system replaces hardcoded `Difs` index selection

## Data Format: YAML Part Definition

```yaml
id: BaseHair
category: hair
parent: Head
connections:
  - name: top_left
    joint: top_left
  - name: top_right
    joint: top_right
  - name: front
    joint: front_hair
  - name: back
    joint: back_hair
  - name: side_left
    joint: side_hair_left
  - name: side_right
    joint: side_hair_right
variants:
  - x: 0
    y: 0
    svg: base_hair_x0y0.svg
morph_x: 1
morph_y: 1
colors:
  hair: { palette: hair, field: HairCD }
```

## Data Format: YAML Race Template

```yaml
id: human
parts:
  torso: { variant: human, morph_x: 0.5, morph_y: 0.3 }
  head: { variant: human }
  hair: { variant: long }
  left_arm: { variant: human }
  right_arm: { variant: human }
  left_leg: { variant: human }
  right_leg: { variant: human }
colors:
  skin: { palette: skin_tones, index: 0 }
  hair: { palette: hair_colors, index: 3 }
```