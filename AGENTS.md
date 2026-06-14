# AGENTS.md — SlaveMatrixDecomp

## Project

Decompilation + modding re-architecture of "Slave Matrix" (Auto Eden). Three .NET 8 projects:
- **SlaveMatrix** (`WinExe`) — game entrypoint `SlaveMatrix.Program.Main` at `SlaveMatrix/SlaveMatrix/GameClasses/Program.cs`
- **2DGAMELIB** (class library) — legacy rendering engine (GDI+) + core data types (BodyTemplate, ShapePart, etc.)
- **SlaveMatrix.Extract** (`Exe`) — asset pipeline CLI; depends on SlaveMatrix for embedded resources

## Build & Run

```
dotnet build Solution.sln          # build all
./run.sh                            # launch game (cds to game_folder/, sets DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1)
dotnet run --project SlaveMatrix.Extract -- --output <path>   # asset extraction
```

The game **must** run with `game_folder/` as working directory. `launchSettings.json` sets this automatically in VS/Rider.

## Key Quirks

- **C# 9.0** (`LangVersion` hardcoded in `.csproj`). No `ImplicitUsings` in SlaveMatrix/2DGAMELIB.
- **x64 only**, `AllowUnsafeBlocks=true`, `InvariantGlobalization=true` (needed on Linux).
- **BinaryFormatter** still in use (legacy saves). Requires `EnableUnsafeBinaryFormatterSerialization=true` and `NoWarn=SYSLIB0011`.
- **`System.Drawing.EnableUnixSupport`** must be set at startup (`runtimeconfig.template.json` + `AppContext.SetSwitch` in `Program.cs`).
- **Newtonsoft.Json** (not `System.Text.Json`) — used in 2DGAMELIB and Extract.
- **Empty `RootNamespace`** in SlaveMatrix and 2DGAMELIB — types live in global namespace.
- **`GenerateAssemblyInfo=false`** — uses legacy `Properties/AssemblyInfo.cs`.
- **No test projects**, no CI/CD, no formatter/linter config.
- **843 BodyPartClasses** (`SlaveMatrix/SlaveMatrix/BodyPartClasses/`). **Do not rename** — C# reflection (`Type.GetType`) resolves joint types by class name at runtime.

## Architecture Notes

- **BodyTemplate** (13 binary `Obj` resources) → `VariantGrid` → `MorphVariant` → `PartGroup` → `ShapePart` tree with cardinal-spline curves and joint points. Deserialized via `BinaryFormatter` + `RemappedTypeBinder` (type remapping for decompiled names).
- **Extract pipeline** (`SlaveMatrix.Extract`) loads the 13 embedded resources, applies `MigrateKeys()` (23-entry runtime KeyMap for Japanese→English), then exports:
  - Intermediate JSON → `extracted/` (gitignored)
  - SVG + YAML per part → `SlaveMatrix/Assets/Parts/` (checked in)
  - `Catalog.yaml` index → `SlaveMatrix/Assets/`
- **EnglishNameMap** in `SlaveMatrix.Extract/Program.cs` (179 entries) is for extraction output naming only. It is separate from the smaller runtime `MigrateKeys` KeyMap which only covers keys the old game code actually looks up.
- **Phase 0 (extraction) is complete.** Phases 1-5 (engine rewrite) are planned in `PLAN.md`.

## Git

- `.gitignore` excludes: `**/bin/`, `**/obj/`, `.vs/`, `.idea/`, `Config.ini`, `game_folder/save/*`, `extracted/`.
- `SlaveMatrix/Assets/` (auto-generated SVGs + YAML) **is** checked in.
- `game_folder/` runtime assets are checked in (bgm, text, etc.).
