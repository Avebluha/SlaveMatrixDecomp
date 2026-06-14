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

## Git

- `.gitignore` excludes: `**/bin/`, `**/obj/`, `.vs/`, `.idea/`, `Config.ini`, `game_folder/save/*`, `extracted/`.
- `SlaveMatrix/Assets/` (auto-generated) **is** checked in.
- `game_folder/` runtime assets are checked in (bgm, text, etc.).
