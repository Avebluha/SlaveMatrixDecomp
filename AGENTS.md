# AGENTS.md — SlaveMatrixDecomp

## Project

Decompilation + modding re-architecture of "Slave Matrix" (Auto Eden). Three .NET 8 projects:
- **SlaveMatrix** (`WinExe`) — game entrypoint `SlaveMatrix.Program.Main` at `SlaveMatrix/SlaveMatrix/GameClasses/Program.cs`
- **2DGAMELIB** (class library) — legacy GDI+ rendering engine + core data types (BodyTemplate, ShapePart, etc.)
- **SlaveMatrix.Extract** (`Exe`) — asset pipeline CLI; depends on SlaveMatrix for embedded resources

## Build & Run

```
dotnet build Solution.sln          # build all
./run.sh                            # cd game_folder/ + DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1 + dotnet run
dotnet run --project SlaveMatrix.Extract -- --output <path>   # asset extraction
```

Game **must** run with `game_folder/` as working directory. `launchSettings.json` sets `../game_folder` automatically.

## Key Quirks

- **C# 9.0** (`LangVersion` in `.csproj`). No `ImplicitUsings` in SlaveMatrix/2DGAMELIB. Extract has `ImplicitUsings=enable` + `Nullable=enable` — it can use modern C#.
- **x64 only**, `AllowUnsafeBlocks=true`, `InvariantGlobalization=true` (required on Linux).
- **BinaryFormatter** for legacy saves: `EnableUnsafeBinaryFormatterSerialization=true`, `NoWarn=SYSLIB0011`.
- **`System.Drawing.EnableUnixSupport`** set at startup (`runtimeconfig.template.json` + `AppContext.SetSwitch` in `Program.cs`). `NoWarn=CA1416` suppresses platform-compat warnings across all projects.
- **Newtonsoft.Json** (not `System.Text.Json`) in 2DGAMELIB and Extract.
- **Empty `RootNamespace`** in SlaveMatrix/2DGAMELIB — types live in global namespace.
- **`GenerateAssemblyInfo=false`** — legacy `Properties/AssemblyInfo.cs`.
- **`global.json`** pins SDK 8.0 with `rollForward=latestMajor, allowPrerelease=true`.
- **No test projects**, no CI/CD, no formatter/linter config.
- **843 BodyPartClasses** (`SlaveMatrix/SlaveMatrix/BodyPartClasses/`). **Do not rename** — C# reflection (`Type.GetType`) resolves joint type names at runtime.

## Architecture

- **BodyTemplate** (13 binary `Obj` resources) → `VariantGrid` → `MorphVariant` → `PartGroup` → `ShapePart` tree (cardinal-spline curves + joint points). Deserialized via `BinaryFormatter` + `RemappedTypeBinder`.
- **Extract pipeline** loads the 13 embedded resources, applies `MigrateKeys()` (20-entry runtime KeyMap for Japanese→English lookups), then exports:
  - Intermediate JSON → `extracted/` (gitignored)
  - SVG + YAML per part → `SlaveMatrix/Assets/Parts/` (checked in)
  - `Catalog.yaml` → `SlaveMatrix/Assets/`
- **EnglishNameMap** in `SlaveMatrix.Extract/Program.cs` (~176 entries) is for extraction output naming only, separate from the runtime KeyMap.
- **game_folder/ content** is copied to build output via `<Content Include="..\game_folder\**\*" CopyToOutputDirectory="PreserveNewest" />`.
- **Phase 0 (extraction) is complete.** Phases 1-5 (engine rewrite, Vulkan/Silk.NET) are planned in `PLAN.md`.

## SlaveEngine.Renderer (Prototype)

- **Project**: `SlaveEngine.Renderer/SlaveEngine.Renderer.csproj` — GLFW + Silk.NET OpenGL + raw GLFW bindings (`glfw` 3.4.0 NuGet)
- **Run**: `dotnet run --project SlaveEngine.Renderer/SlaveEngine.Renderer.csproj` (or `dotnet run -c Release` for 10× faster geometry processing)
- **Default working dir is project root** (`Assets/` directory with `.spart` files must be reachable)
- **Renders MorphVariants** (VariantAssets) in a grid — each tile shows all PathGroups of one variant composed together with transforms
- **2-pass pipeline**: (1) Ear-clip triangulation for fills (colored by hash), (2) Stroke-line extrusion via `ToStrip` (white outlines)
- **`MaxVariants = 12`** kept low since ear-clip triangulation is O(n³) and slow in Debug mode

### Keyboard Navigation
| Key | Action |
|-----|--------|
| ←/→ | Previous/next part asset (category) |
| ↑ | Focus on first single asset |
| ↓ | Show all assets |
| Home | Jump to first asset |
| End | Jump to last asset |
| Space | Reset camera pan/zoom |
| Esc | Exit |
| Left-drag | Pan camera |
| Scroll | Zoom at cursor |
| Right-click | Toggle wireframe overlay |

### Architecture
- `Program.cs` — main loop, asset loading, geometry baking, GL state
- `GLFWWindow.cs` — raw GLFW wrapper implementing `IGameWindow`
- `IGameWindow.cs` — window abstraction with mouse + key event interface (`KeyCode` enum, `KeyDown` event)
- Asset loading via `SlaveEngine.Assets` (`.spart` binary format → `PartAsset`/`VariantAsset`/`PathGroup`/`PathData`)
- Geometry processing via `SlaveEngine.Graphics` (`Spline.*`, `Triangulation.*`)
- Polyline caches (`polylineCacheCoarse` + `polylineCacheFine`) avoid redundant `CommandsToPolylines` calls during keyboard navigation
- Cleanup: old GL shader/buffer/VAO handles are deleted before rebuild on navigation

### Phoenix Character (Phases 1+)

- **PhoenixParts[]** in `Program.cs:165-215` defines 37 parts with variant selectors, mirror flags, rotations, and offsets.
- **Character mode** (`P` key) loads all 37 parts, computes a global centering offset from their union bbox, then applies per-part mirrorX→RotOffset→PosOffset.
- **PosOffset (offX/offY)** is applied LAST in `ApplyExtraTransforms()` at `Program.cs:800` — after centering, mirror, and rotation. This means offY for rotated parts rotates with the part.

### Known Part-Positioning Issues

ViewBox geometry bounds (computed from SVG path data + PathGroup transforms):

| Part | ViewBox Y-range | Notes |
|------|----------------|-------|
| Waist | [0.195, 0.285] | Bottom = 0.285 |
| Torso | [0.140, 0.218] | |
| Chest | [0.078, 0.162] | |
| Neck | [0.056, 0.109] | |
| Head | [0.024, 0.069] | |
| Shoulder | [0.142, 0.181] | Sits at Waist/Torso boundary |
| 鳥翼UpperArm | [0.132, 0.179] | Overlaps Shoulder vertically |
| 鳥翼LowerArm | [0.134, 0.187] | |
| BirdWingHand | [0.145, 0.179] | |
| QuadrupedThigh | [0.394, 0.464] | Top=0.394 → 0.109 gap to Waist |
| QuadrupedLeg | [0.451, 0.510] | |
| QuadrupedFoot | [0.451, 0.514] | |
| Tail (y=9) | [0.264, 0.292] | Just below Waist bottom |
| Tail_肢中 (x=2) | [0.552, 0.571] | Far below body |

**Remaining gaps (2026-06-14):**
- Waist→Thigh: `offY: -0.109` applied but may need retuning
- Tail_肢中: needs `offY` (~-0.25 guessed) — rotation makes exact value non-trivial
- Shoulder→UpperArm joint: Y-overlap exists but visual disconnection reported
- Proper HSV-based skin/clothing gradients not implemented
- Bird tail (y=9) at Y=[0.264,0.292] — only extends 0.007 below waist bottom (0.285)

## Git

- `.gitignore` excludes: `**/bin/`, `**/obj/`, `.vs/`, `.idea/`, `Config.ini`, `game_folder/save/*`, `extracted/`.
- `SlaveMatrix/Assets/` (auto-generated) **is** checked in.
- `game_folder/` runtime assets are checked in (bgm, text, etc.).
