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

- **Phase 0 complete** (`engine-rewrite` branch, pushed to `gitea`)
- 843 BodyPartClasses with Japanese filenames (not yet touched)
- 13 binary `Obj` resources embedded in `.resx` (5.5MB largest)
- `MigrateKeys()` runtime key-mutation for 4 of 13 resources (fragile, incomplete)
- 1,660 unique string keys across all resource lookups
- BinaryFormatter double-wrapped serialization
- GDI+ rendering with cardinal splines, GraphicsPath, hit-testing
- Existing `Ser.ToJson`/`Ser.UnJson` infrastructure (patched for private fields and OrderedDictionary)

### Phase 0 Deliverables

**Asset pipeline tool** — `SlaveMatrix.Extract` CLI:
- Loads all 13 binary resources via `ObjLoadRaw()` (GDI+-free deserialization)
- Applies `MigrateKeys()` for 23 KeyMap entries
- Exports structured JSON intermediate format
- Converts cardinal spline curves to cubic Bézier SVG paths
- Generates YAML sidecar files per body part
- Outputs `Catalog.yaml` runtime index

**Asset directory** — `SlaveMatrix/Assets/`:
```
Assets/
  Catalog.yaml                           <- 175 entries, auto-generated
  Parts/                                 <- one directory per body part key
    BaseHair/                            <- English name (after MigrateKeys)
      part.yaml                          <- id, original_key, resource, joints, fields, variants
      x0y0.svg                           <- morph variant (X=0, Y=0)
    BackHair0/
      part.yaml
      x0y0.svg ... x0y21.svg             <- 22 morph variants
    FrontHair/
      part.yaml
      x0y0.svg ... x0y18.svg             <- 19 morph variants
    上着ボトム後/                          <- Japanese name (not in KeyMap yet)
      part.yaml
      x0y0.svg, x0y1.svg
    ...
  Races/                                 <- (planned, Phase 2)
  Colors/                                <- (planned, Phase 3)
```

**Key stats:**
- 175 body parts extracted across 13 resources
- 838 SVG files (one per morph variant)
- 175 YAML sidecar files
- 1 Catalog.yaml index
- KeyMap entries for 23 Japanese→English mappings


## Phase 0: Resource Extraction & Asset Pipeline ✅ COMPLETE

### 0.1: Fix JSON Serialization ✅

- Add `JsonConverter<OrderedDictionary<T1,T2>>` for proper dictionary round-tripping
- Manual export walker instead of JsonSerializer serialization (avoids GDI+ and self-reference issues)
- Add `ObjLoadRaw()` for GDI+-free binary resource loading
- Clean JSON methods using `JsonConvert` API with consistent settings

### 0.2: Build Key Map ✅

- Added hair class entries: `基髪→BaseHair`, `胸毛→ChestHair`, `前髪→FrontHair`
- 23 total KeyMap entries (pre-existing + new)
- No Pars-level recursive migration needed (manual export avoids it)

### 0.3: Write Extraction Console App ✅

- Created `SlaveMatrix.Extract` console project
- Loads all 13 `Obj` from embedded resources via `ObjLoadRaw()`
- Applies `MigrateKeys()` with current KeyMap
- Exports each `Obj` to intermediate JSON file
- For SVG export: converts cardinal spline to cubic Bezier via Catmull-Rom tension formula
- For YAML: exports part metadata (id, original_key, resource, morph dimensions, joints, variant SVGs)
- Outputs `Catalog.yaml` index of all parts

### 0.4: Validate Extraction ✅

- Manual inspection of SVG output confirms valid path data with cubic Bezier curves
- All 175 parts export without errors
- 838 SVGs generated across all morph variants

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

### Target (YAML + SVG) ✅ Phase 0 complete

```
Assets/
  Catalog.yaml                    <- auto-generated index
  Parts/
    BaseHair/                     <- one dir per body part (English name)
      part.yaml                   <- sidecar: id, original_key, resource, morph, joints, fields
      x0y0.svg                    <- morph variant SVG (X index, Y index)
      x0y1.svg                    <- next morph variant
    ...
  Races/                          <- (planned, Phase 2)
  Colors/                         <- (planned, Phase 3)

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

## Data Format: YAML Part Definition (actual)

```yaml
id: BaseHair
original_key: 基髪
resource: 胴体
morph_x: 1
morph_y: 1
variants:
- x: 0
  y: 0
  file: x0y0.svg
fields:
- name: 髪
joints:
- position: [0.34, 0.34]
- position: [0.39, 0.34]
- position: [0.37, 0.33]
- position: [0.37, 0.34]
```

## Data Format: YAML Race Template (planned)

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