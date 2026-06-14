# Slave Matrix Internal Architecture

A detailed technical analysis of how the program works from startup to rendering a character on screen, with focus on asset loading and generalization strategy.

---

## 1. Startup Pipeline

```
Program.Main()
  │
  ├─ [STATIC INIT] Type initializer for GlobalState (before Main)
  │    └─ Program static cctor (#1)
  │         ├─ AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true)
  │         └─ RemappedTypeBinder.RegisterMapping for 3 game types
  │              "SlaveMatrix.Ele"    → Element
  │              "SlaveMatrix.EleD"   → ElementData
  │              "SlaveMatrix.EleI"   → ElementInstance
  │
  ├─ GlobalState static cctor (#2)
  │    ├─ Sets CurrentDirectory = AppContext.BaseDirectory
  │    ├─ Loads 13 BodyTemplate Obj resources from embedded bytes
  │    │    Each: byte[] → BinaryFormatter→byte[] → BinaryFormatter→BodyTemplate
  │    ├─ MigrateKeys() — 20-entry KeyMap renames Japanese→English keys
  │    ├─ Caches 843 BodyPartClass Type objects for reflection-based Element creation
  │    ├─ Verifies type resolution (Type.GetType) for all race-part combos
  │    └─ Sets imiPath, panPath for onomatopoeia/moaning text directories
  │
  ├─ Main()
  │    ├─ GlobalState.LoadConfig() — reads game_folder/Config.ini
  │    │    Booleans: BigWindow, HighQuality, ShowFPS, etc.
  │    │
  │    ├─ Create ModeEventDispatcher
  │    │    ├─ UITitle = game title string
  │    │    ├─ Unit = scaling factor (2203 HQ / 1101.5 LQ)
  │    │    ├─ Base = Rectangle(4f, 3f, percent/100f)  — aspect ratio + viewport
  │    │    ├─ DisQuality = 1.0
  │    │    └─ HitAccuracy = 0.3
  │    │
  │    ├─ med.InitializeModes("Start", ModuleRegistry.GetMods)
  │    │    └─ GetMods callback registers 25+ screen modules via RegisterModule()
  │    │
  │    └─ med.Drawing() — creates GLFW window, enters main loop, never returns
  │
  └─ [MAIN LOOP] med.Drawing()
       ├─ GlImage.BitmapSetting(Display)
       │    ├─ GLFW 3.3 + OpenGL 3.3 Core profile window, size = Display bitmap dims
       │    ├─ Compiles vertex+ fragment shader (simple textured quad)
       │    ├─ Creates full-screen triangle-strip VAO/VBO
       │    └─ Sets up callbacks: Click, Move, Leave, Scroll, Resize → Module routing
       │
       ├─ med.Setting(GlImage)
       │    ├─ Creates Display Bitmap (Base.LocalWidth * Unit × Base.LocalHeight * Unit px)
       │    ├─ Creates Hit Bitmap (same × HitAccuracy = 0.3)
       │    ├─ Creates SceneFader for crossfade transitions
       │    └─ Calls GetMods(this) → ModuleRegistry populates all Module delegates
       │
       └─ while(Drive)
            ├─ FPSF.FPSFixed(action) — fixed 60 fps timestep
            │    └─ action: Modes[mode].Draw(FPSF) for active screen module
            ├─ baseControl.PollEvents() — GLFW event pump
            └─ baseControl.SetBitmap(Display)
                 ├─ glTexSubImage2D(GDI+ Bitmap → OpenGL texture)
                 ├─ glDrawArrays(TriangleStrip, 0, 4)
                 └─ Glfw.SwapBuffers(window)
```

### Key files

| Step | File | Lines |
|------|------|-------|
| Program.Main | `SlaveMatrix/GameClasses/Program.cs` | 18-43 |
| GlobalState static init | `SlaveMatrix/GameClasses/GlobalState.cs` | 1087-1429 |
| ModeEventDispatcher ctor | `2DGAMELIB/ModeEventDispatcher.cs` | 78-99 |
| Drawing() loop | `2DGAMELIB/ModeEventDispatcher.cs` | 290-325 |
| Setting() | `2DGAMELIB/ModeEventDispatcher.cs` | 101-232 |
| GlImage.BitmapSetting | `2DGAMELIB/WPFImage.cs` | 146-238 |
| GlImage.SetBitmap | `2DGAMELIB/WPFImage.cs` | 99-144 |
| ModuleRegistry.GetMods | `SlaveMatrix/GameClasses/ModuleRegistry.cs` | 204-493 |

---

## 2. Module System (Screen Management)

Each "screen" is a `Module` struct — a set of delegate callbacks:

```csharp
public struct Module {
    public Action<FpsCounter, ModeEventDispatcher> Draw;
    public Action<MouseButtons, Vector2D, Color> Down, Up, Move;
    public Action Leave;
    public Action<Vector2D> Wheel;
    public Action Setting;
    public Action Dispose;
}
```

Registered via `ModeEventDispatcher.RegisterModule(string name, Module mod)`. 25 modules include:

| Module Name | Purpose |
|-------------|---------|
| `Start` | Initial screen |
| `Title` | Title screen |
| `Credit` | Credits |
| `メインフォーム` (MainForm) | Primary HUD/gameplay |
| `対象` (Target) | Character target selection |
| `Training` | Training/interaction scene |
| `Blessing`, `Office` | Other gameplay scenes |
| `Debt` | Debt management |
| `SlaveShop`, `ToolShop` | Shop screens |
| `PlayerInformation` | Player status |
| `OP0`, `OP1`, `説明`, `初事務所` | Event scenes |
| `RepaymentEvent1-3` | Story events |

**Mode switching**: `ModeEventDispatcher.Mode = name` calls `Leave` on the old module and `Setting` on the new module.

**Module draw delegates** are defined inline in `ModuleRegistry.GetMods()` — typically compositing multiple `RenderArea` layers, characters, and UI elements.

---

## 3. Asset Loading Architecture

### 3.1 The 13 Binary Resources

Embedded as `byte[]` in `SlaveMatrix/Properties/Resources.resx`, accessed via `Resources.xxx`:

| # | Resource Name | Contents (after MigrateKeys) |
|---|---------------|------------------------------|
| 1 | `Resources.胴体` | Torso, Waist, Neck, Head, Chest, BackHair0/1, SideHair, etc. |
| 2 | `Resources.肩左` | Shoulder variants |
| 3 | `Resources.腕左` | Arm, UpperArm, LowerArm, + wing/beast/quadruped variants |
| 4 | `Resources.脚左` | Leg variants |
| 5 | `Resources.尻尾` | Tail variants |
| 6 | `Resources.半身` | Half-body composites |
| 7 | `Resources.肢左` | Limb variants |
| 8 | `Resources.肢中` | Middle limb variants |
| 9 | `Resources.性器` | Genital variants |
| 10 | `Resources.性器付` | Genitals with attachments |
| 11 | `Resources.スタンプ` | Stamp/stencil overlays |
| 12 | `Resources.カーソル` | Cursor graphics |
| 13 | `Resources.その他` | Miscellaneous |
| — | `Resources.タイル` | Tile/background patterns |

### 3.2 Deserialization Pipeline

```
byte[] raw = Resources.胴体
  │
  ├─ Serializer.Load<byte[]>(raw)           // FIRST deserialization
  │    └─ new BinaryFormatter { Binder = RemappedTypeBinder }
  │         .Deserialize(new MemoryStream(raw))
  │    └─ RemappedTypeBinder translates:
  │         _2DGAMELIB.Obj  → BodyTemplate   (outer layer is Obj wrapping a byte[])
  │    └─ Result: byte[] innerData
  │
  └─ innerData.ToDeserialObject<BodyTemplate>()   // SECOND deserialization
       └─ new BinaryFormatter { Binder = RemappedTypeBinder }
            .Deserialize(new MemoryStream(innerData))
       └─ RemappedTypeBinder translates:
            _2DGAMELIB.Obj  → BodyTemplate
            _2DGAMELIB.Difs → VariantGrid
            _2DGAMELIB.Dif  → MorphVariant
            _2DGAMELIB.Pars → PartGroup
            _2DGAMELIB.Par  → ShapePart
            _2DGAMELIB.ParT → ShapePartT
            _2DGAMELIB.Out  → CurveOutline
            _2DGAMELIB.Joi  → JointPoint
       └─ Result: BodyTemplate with full object graph
```

The **double-wrapping** is a legacy artifact: the `.resx` stores the data as `byte[]`, but the original source wrapped a `byte[]` containing a serialized `BodyTemplate` inside another `BinaryFormatter` envelope.

### 3.3 Post-Deserialization

1. **`SetDefaultR()`** — initializes all PartGroup runtime fields to defaults
2. **`MigrateKeys()`** — replaces 20 Japanese keys in `BodyTemplate.Difss` with English names
3. **Type caching** — iterates all `VariantGrid` keys + race suffixes (人/猫/獣/鳥/蜘蛛/蜥蜴/魚/蛙/四足/水棲/半人鮫/竜/植物/巨人/妖精/兎/狐/熊/馬/鹿/狼/河馬/恐/牛/羊/鬼/亜人/機械/蛇/狗/黄金/冥府/冥界/天使/墮天使) and caches `Type.GetType("BodyPartName_RaceSuffix")` for each.

### 3.4 KeyMap (Runtime)

Defined in `2DGAMELIB/ObjExtensions.cs` — 20 entries:

| Japanese | English |
|----------|---------|
| 咳 → Cough | 腰 → Waist | 胴 → Torso | 首 → Neck |
| 頭 → Head | 後髪0 → BackHair0 | 後髪1 → BackHair1 | 横髪 → SideHair |
| 脚 → Leg | 腕 → Arm | 肩 → Shoulder | 胸 → Chest |
| 下腕 → LowerArm | 上腕 → UpperArm |
| 鳥翼上腕/獣翼上腕/四足上腕 → 鳥翼UpperArm/獣翼UpperArm/四足UpperArm |
| 鳥翼下腕/獣翼下腕/四足下腕 → 鳥翼LowerArm/獣翼LowerArm/四足LowerArm |

### 3.5 game_folder Runtime Assets

Copied to build output via `.csproj`:
```xml
<Content Include="..\game_folder\**\*" CopyToOutputDirectory="PreserveNewest" LinkBase="" />
```

Loaded at runtime:
- **Text**: `GameText` static ctor loads `text/System/Race.txt`, `Attribute.txt`, `Common.txt`, and scene-specific text
- **Onomatopoeia/Moaning**: `GlobalState.Set擬音()` → `Imitation.txt`; `Set喘ぎ()` → `Pant/*.txt`
- **Config**: `game_folder/Config.ini`
- **BGM**: Expected in `bgm/` (currently commented out in code)
- **Saves**: `save/*.sav` (BinaryFormatter) or `.json`
- **Background images**: *loaded from embedded resources*, not game_folder (e.g., `Resources.dangeon01_ex2`)

---

## 4. Data Model

### 4.1 Hierarchy

```
BodyTemplate                               [Serializable]
  └── OrderedDictionary<string, VariantGrid>  "Difss"
        ├── Key: "Waist", "Torso", "Neck", "Head", ...
        │
        └── VariantGrid                    [Serializable]  (.Difs)
              ├── CountX : int             ← morph grid width (ValueX axis)
              ├── CountY : int             ← morph grid height (ValueY axis)
              ├── ValueX : double          ← current X selection (0..1 → index)
              ├── ValueY : double          ← current Y selection (0..1 → index)
              ├── PositionSize : Rectangle ← inherited from parent template
              ├── PositionVector : Vector2D
              ├── AngleBase : double
              ├── SizeBase : double
              └── List<MorphVariant> difs   ← linear array [x * CountY + y]
                    │
                    └── MorphVariant        [Serializable]  (.Dif)
                          ├── Tag : string
                          └── List<PartGroup> parss
                                │
                                └── PartGroup              [Serializable]  (.Pars)
                                      ├── Tag : string
                                      ├── Parent : PartGroup (runtime, non-serialized)
                                      └── OrderedDictionary<string, object> pars
                                            ├── Key: "childPartName"
                                            │
                                            ├── ShapePart   [Serializable]  (.Par)
                                            │     ├── Dra : bool             ← visibility
                                            │     ├── Closed : bool
                                            │     ├── PenWidth : double
                                            │     ├── BasePoint : Vector2D   ← local origin
                                            │     ├── Position : Vector2D    ← translation
                                            │     ├── Angle : double         ← rotation
                                            │     ├── Size : double          ← uniform scale
                                            │     ├── SizeX / SizeY : double ← non-uniform scale
                                            │     ├── HitColor : Color       ← unique per part
                                            │     ├── OP : List<CurveOutline>
                                            │     │     ├── ps : List<Vector2D>  ← control points
                                            │     │     ├── Tension : float      ← cardinal spline
                                            │     │     └── Outline : bool       ← stroke-only?
                                            │     ├── JP : List<JointPoint>
                                            │     │     └── Joint : Vector2D     ← attachment point
                                            │     ├── Brush : Brush (runtime, [JsonIgnore])
                                            │     └── Pen : Pen (runtime, [JsonIgnore])
                                            │
                                            ├── ShapePartT  [Serializable]  (.ParT)
                                            │     └── extends ShapePart
                                            │           ├── Text : string
                                            │           ├── FontSize : double
                                            │           └── Font : Font (runtime)
                                            │
                                            └── PartGroup (recursive nesting)
```

### 4.2 Coordinate System

- **Local space**: points in `CurveOutline.ps[]` — normalized 0..1 range
- **Part space**: transformed by `BasePoint`, `Position`, `Angle`, `Size/SizeX/SizeY`
- **Parent space**: transformed by parent chain (PartGroup hierarchy)
- **VariantGrid space**: further transformed by `VariantGrid.PositionVector`, `AngleBase`, `SizeBase`
- **Screen space**: multiplied by `Unit` (2203 or 1101.5)

### 4.3 Joint System

`SetJoints()` on `BodyTemplate` builds:
- **`pj`** (`Dictionary<PartGroup, List<Joint>>`) — joints per PartGroup
- **`pr`** (`Dictionary<PartGroup, ShapePart>`) — the root ShapePart for each PartGroup's joints
- **`JoinRoot`** — identifies the anchor point in parent space

`JoinPA()` propagates angle changes through the chain:
```
Parent.Angle → drives → Child.Position offset via joint point
```

### 4.4 Morph Variant Selection

`VariantGrid.ValueX` (0..1) → `indexX = Clamp((int)(ValueX * (CountX - 1)), 0, CountX - 1)`
`VariantGrid.ValueY` (0..1) → `indexY = Clamp((int)(ValueY * (CountY - 1)), 0, CountY - 1)`
Current MorphVariant: `difs[indexX * CountY + indexY]`
Current PartGroup: `Current.parss[IndexY]` — then draws all children

This means X axis iterates across `difs[]` while Y iterates within a `MorphVariant.parss[]`. The first entry (Y=0) of the current X gives the active PartGroup tree.

---

## 5. Rendering Pipeline (Per-Frame)

### 5.1 Compositing Layers

```
[Module.Draw(FPSF)]
  │
  ├─ Med.HitGraphics.Clear(Color.Transparent)
  │
  ├─ a.Draw(BasementBackground)         ← background layer (embedded bitmap)
  │    └─ RenderArea.Draw(RenderArea other)
  │         └─ DisplayGraphics.DrawImage(other.DisplayLayer, ...)
  │
  ├─ TrainingTarget.Draw(a, FPS)        ← character layer
  │    └─ Character.Draw(Area, FpsCounter)
  │
  ├─ bs.Draw(a)                         ← UI button layer
  ├─ dbs.Draw(a)                        ← bottom button layer
  ├─ ip.Draw(a, FPS)                    ← info panel layer
  ├─ SaveData.Draw(a)                   ← save data overlay
  │
  └─ Med.Draw(a)                        ← composite to main display
       └─ RenderArea.DrawTo(Med.Display, Med.Hit)
            └─ DisplayGraphics.DrawImage(a.DisplayLayer, 0, 0)
            └─ HitGraphics.DrawImage(a.HitLayer, 0, 0)
```

### 5.2 Character Draw

```
Character.Draw(Area, FPS)
  ├─ Motions.Drive(FPS) — update all animation state
  │    ├─ Breathing: oscillates Chest/Abdomen size
  │    ├─ Blinking: triggers Eye morph (Xv/Yv → closed)
  │    ├─ Tear/Cum/Squirt/Urination: fluid system updates
  │    ├─ Sway: body angle oscillation
  │    ├─ Eye tracking: head angle toward cursor
  │    ├─ Cough/Moan: variant cycling
  │    └─ User-defined morph motions
  │
  └─ Body.描画(Area)
       ├─ 接続PA() — propagate parent angles through joint chains
       │    └─ For each Element: Element.Body.JoinPA()
       │         └─ VariantGrid.JoinPA() recurses PartGroups
       │              └─ ShapePart.Rotate() updates child positions
       │
       ├─ Color updates: skin/dress/wing membrane/etc.
       ├─ ElementInstance updates
       │
       └─ Draw(Area) delegate
            └─ Elements sorted by 描画前後 (back-to-front)
                 ├─ Element.描画0(Are)  — main body
                 │    └─ VariantGrid.Draw(Are)
                 │         └─ Are.Draw(Current PartGroup)
                 │              └─ PartGroup.Draw(Unit, Graphics)
                 │                   └─ for each child in pars:
                 │                        ├─ if ShapePart + Dra:
                 │                        │    ShapePart.Draw(Unit, Graphics)
                 │                        ├─ if ShapePartT:
                 │                        │    ShapePartT.DrawString(Unit, Graphics)
                 │                        └─ if PartGroup:
                 │                             recursive PartGroup.Draw()
                 │
                 ├─ Element.描画1(Are)  — overlay layer 1
                 └─ Element.描画2(Are)  — overlay layer 2
```

### 5.3 ShapePart.Draw()

```
ShapePart.Draw(double Unit, Graphics g)
  ├─ if (Edit flag) → Calculation(Unit):
  │    ├─ BaseTransform = -BasePoint * Size (shifts to origin)
  │    ├─ Position += ParentChain offset
  │    ├─ Angle += ParentChain angle
  │    ├─ Size *= ParentChain scale
  │    ├─ For each CurveOutline:
  │    │    └─ Transform points through: base → scale → rotate → translate
  │    ├─ Build GraphicsPath.Path via AddCurve(pointArray, tension)
  │    ├─ Build GraphicsPath.OutlinePath for stroke-only curves
  │    └─ Clear Edit flag
  │
  ├─ Brush.Color = resolve runtime color (from Element.ColorSet)
  ├─ g.FillPath(Brush, Path)
  └─ if (Outline curves exist) → g.DrawPath(Pen, OutlinePath)
```

### 5.4 Hit Detection

Rendered on a separate lower-resolution `Hit` Bitmap. Each `ShapePart` has a unique `HitColor`. Module mouse callbacks check the pixel color under the cursor:

```csharp
Color hit = Med.Hit.GetPixel((int)(pos.X * HitAccuracy), (int)(pos.Y * HitAccuracy));
// match hit to Element via HitColor → find which part was clicked
```

### 5.5 RenderArea Hierarchy

```
RenderArea : Rectangle
  ├── DisplayLayer : Bitmap (full-res, visible output)
  ├── HitLayer : Bitmap (low-res, hit detection)
  ├── DisplayGraphics : Graphics (wraps DisplayLayer)
  ├── HitGraphics : Graphics (wraps HitLayer)
  ├── Draw(ShapePart) → renders to both layers
  ├── Draw(PartGroup) → recursive render
  ├── Draw(RenderArea) → composite another area onto this one
  └── DrawTo(display, hit) → final composite to Med.Display/Med.Hit

ManagedArea : RenderArea
  └── Lower-resolution render target for character body (3x3 internal cells)
```

---

## 6. Character System

### 6.1 Element Class

Each `Element` wraps a single `VariantGrid` from a BodyTemplate resource. 843 Element subclasses in `BodyPartClasses/` define concrete body parts with race-specific behavior.

```
Element                                [Serializable]
  ├── 本体 : VariantGrid               ← the template data
  ├── 位置B / 位置C : Vector2D         ← position base/contract
  ├── 角度B / 角度C : double           ← angle base/contract  
  ├── 尺度B / 尺度C : double           ← scale base/contract
  ├── Xv / Yv : double                ← morph variant selection (drives ValueX/Y)
  ├── 描画前後 : int                  ← render order (back:0, middle:1, front:2)
  ├── 接続Type : int                  ← joint connection type
  ├── ColorSlot : int                 ← which color set to use
  ├── 拡張 : OrderedDictionary         ← extension data
  │
  ├── 描画0(Are) → 本体.Draw(Are)     ← main render
  ├── 描画1(Are) → 本体.Draw(Are)     ← overlay 1
  └── 描画2(Are) → 本体.Draw(Are)     ← overlay 2
```

### 6.2 Element Construction via Reflection

In `Body` constructor, Elements are instantiated by `Type.GetType()`:

```csharp
// Simplified:
string typeName = $"_{partKey}_{raceSuffix}";  // e.g., "Head_人"
Type t = GlobalState.BodyTypeCache[typeName];
Element ele = (Element)Activator.CreateInstance(t);
ele.本体 = GlobalState.BodyTemplates[resourceName].Difss[partKey];
```

843 files mean 843 `Type` lookups. The reflection names use **original Japanese** keys (pre-MigrateKeys) for the `_人/猫/etc` suffix convention.

### 6.3 Body Class

```
Body
  ├── Elements : Element[]              ← flat array of all parts
  ├── Strongly-typed fields:
  │    Waist, Torso, Chest, Neck, Head,
  │    BackHair0, BackHair1, SideHair, BaseHair, FrontHair,
  │    EyeL, EyeR, Nose, Mouth, EyebrowL, EyebrowR,
  │    BreastL, BreastR, Belly,
  │    Genitals, Anus,
  │    UpperArmL/R, LowerArmL/R, HandL/R,
  │    ShoulderL/R,
  │    UpperLegL/R, LowerLegL/R, FootL/R,
  │    WingL/R, Tail,
  │    etc. (~80 fields)
  │
  ├── 接続PA() — joint angle propagation
  ├── 描画(Area) — main render entry
  └── Draw(Area) delegate — sorted Element rendering
```

### 6.4 Character Class

```
Character
  ├── Body : Body
  ├── Motions : Motions                ← animation controller
  ├── FluidSystem : CharacterFluidSystem
  ├── CharacterData : CharacterData    ← race, colors, stats
  │
  ├── Draw(Area, FPS) → Body.描画(Area)
  └── Motions.Drive(FPS) — updates all animation state
```

### 6.5 Animation System (Motions)

The `Motions` class manages a collection of `Motion` objects. Each `Motion` modifies Element properties over time:

- **Breathing**: oscillates `Chest.尺度C` and `Belly.尺度C` using a sine wave
- **Blinking**: transitions `EyeL.Yv` / `EyeR.Yv` to 1 (closed) then back
- **Cough**: cycles `Cough.Xv` through morph variants
- **Sway**: oscillates body `角度B` (Angle Base)
- **Eye tracking**: sets `Head.角度C` toward cursor position
- **Fluid drip**: tears, drool, cum, squirt, urination — updates fluid system
- **Climax**: full-body spasm (randomized element position/angle jitter)

Each `Motion` implements `Drive(FPS)` which time-samples a curve/function and applies deltas to `Element.Xv`, `Yv`, `位置B/C`, `角度B/C`, `尺度B/C`.

---

## 7. Generalization Strategy

### 7.1 Replace BinaryFormatter (Data Layer)

**Current**: `byte[] → BinaryFormatter→byte[] → BinaryFormatter→BodyTemplate`

**Target**: Load from structured files. Extraction is already done via `SlaveMatrix.Extract`:

```
Embedded .resx bytes  ──[Extract CLI]──▶  extracted/*.json  (full template data)
                                           Assets/Parts/{id}/part.yaml  (per-part metadata)
                                           Assets/Parts/{id}/x{y}x{y}.svg  (variant curves)
                                           Assets/Catalog.yaml  (runtime index)
```

**Strategy**:
1. Parse `Catalog.yaml` → discover all parts
2. For each part, load `part.yaml` → get morph dimensions, joints, fields, variant list
3. For active morph (Xv/Yv), load corresponding SVG → parse path data → extract control points
4. Rebuild `ShapePart`-equivalent geometry from SVG path data

### 7.2 Replace GDI+ (Rendering Layer)

**Current**: `System.Drawing.Graphics.FillPath/DrawPath` on GDI+ `GraphicsPath` built via `AddCurve(points, tension)`.

**Target**: Vulkan/Silk.NET (or any modern GPU API).

**Strategy**:
1. Cardinal spline → cubic Bezier conversion (already done in SVG export — `BuildSvgPath` in Extract)
2. Tessellate cubic Bezier curves into triangles (or use GPU path rendering)
3. Maintain the same transform chain:
   ```
   localPoint → baseTransform → scale → rotate → translate → parentTransform → Unit
   ```
4. Replace hit-testing: render with unique color IDs to offscreen buffer, sample pixel

### 7.3 Critical Data to Preserve

```
ShapePart (or equivalent):
  - CurveOutline[] → Points[] (local coords), Tension, Outline flag
  - Closed → fill vs stroke
  - BasePoint → local origin
  - Position → translation in parent space
  - Angle → rotation
  - Size, SizeX, SizeY → scale
  - Joints → attachment positions in local coords
  - Dra → visibility
  - HitColor → unique ID for hit testing

PartGroup (or equivalent):
  - Tree hierarchy (ordered children)
  - Parent reference

VariantGrid (or equivalent):
  - CountX, CountY → morph grid dimensions
  - ValueX, ValueY → current selection → (xIndex, yIndex)
  - PositionVector, AngleBase, SizeBase → root transform

MorphVariant (or equivalent):
  - Per-variant PartGroup tree
```

### 7.4 Joint System Generalization

Current: `SetJoints()` builds proximity-based joint dictionaries. PartGroups have `JointPoint` lists that define connection anchors.

Target: Explicit joint definitions in YAML (already in extracted `part.yaml`):

```yaml
joints:
  - position: [0.50, 0.47]   # pre-computed world-space joint positions
  - position: [0.48, 0.52]
```

**Strategy**:
1. Define explicit parent-child joint connections in a race template YAML
2. Match joint positions between adjacent parts (or name them explicitly)
3. `JoinPA()` equivalent: when parent rotates, propagate angle through the joint point offset

### 7.5 Morph Variant Generalization

Current: Discrete X/Y index into `List<MorphVariant>`. Selection via `(int)(ValueX * (CountX-1))`.

Target: Support both discrete selection and interpolation:

```yaml
# interpolate between variant x0y0 and x0y1
morph:
  x: 0.3  # selects x=0, interpolates 30% toward next X
  y: 0.0
```

**Strategy**:
1. Load both adjacent SVG variants
2. Interpolate control point positions: `p = lerp(p_a, p_b, t)`
3. Rebuild path geometry from interpolated points

### 7.6 Suggested Implementation Order

```
Phase 1: Data layer
  ├── JSON/YAML deserializer for extracted assets
  ├── BodyTemplate/VariantGrid/MorphVariant ⇒ plain C# records
  └── replaces BinaryFormatter dependency

Phase 2: Rendering backend
  ├── Curve tessellator (cardinal spline → bezier → triangles)
  ├── Transform chain (preserve hierarchy logic)
  ├── Hit detection (offscreen ID buffer)
  └── ShapePart.Draw equivalent in new backend

Phase 3: Character assembly
  ├── Joint system (explicit YAML connections)
  ├── Element system (part instance with morph state)
  ├── Animation (Motion/Motions port)
  └── Character.Draw equivalent

Phase 4: Migration
  ├── Port BodyPartClasses → data-driven definitions
  ├── Port UI system → new rendering backend
  ├── Replace Module system → scene graph
  └── Wire game logic (training, shops, events)
```

---

## Appendix: Key File Index

| File | Role |
|------|------|
| `SlaveMatrix/GameClasses/Program.cs` | Entry point, static cctor, Main |
| `SlaveMatrix/GameClasses/GlobalState.cs` | Global static state, template loading, type cache |
| `SlaveMatrix/GameClasses/ModuleRegistry.cs` | Module definitions, UI, game initialization |
| `SlaveMatrix/GameClasses/Character.cs` | Character class + animation |
| `SlaveMatrix/GameClasses/Body.cs` | Body assembly + rendering |
| `SlaveMatrix/GameClasses/Element.cs` | Element base class (VariantGrid wrapper) |
| `SlaveMatrix/GameClasses/ElementInstance.cs` | Runtime Element instance |
| `SlaveMatrix/GameClasses/ElementData.cs` | Serializable Element data |
| `SlaveMatrix/GameClasses/GameText.cs` | Game text loader |
| `SlaveMatrix/BodyPartClasses/*.cs` | 843 concrete Element subclasses |
| `2DGAMELIB/ModeEventDispatcher.cs` | Main loop, mode switching, GLFW integration |
| `2DGAMELIB/WPFImage.cs` | GLFW window, OpenGL texture upload (GlImage) |
| `2DGAMELIB/RenderArea.cs` | Offscreen render buffer (display + hit) |
| `2DGAMELIB/ManagedArea.cs` | Lower-res render area |
| `2DGAMELIB/SceneFader.cs` | Crossfade transition |
| `2DGAMELIB/Module.cs` | Module delegate struct |
| `2DGAMELIB/BodyTemplate.cs` | Top-level template container |
| `2DGAMELIB/VariantGrid.cs` | Morph variant grid |
| `2DGAMELIB/MorphVariant.cs` | Morph variant (PartGroup list) |
| `2DGAMELIB/PartGroup.cs` | Part group tree node |
| `2DGAMELIB/ShapePart.cs` | Drawable shape (curves, joints, transforms) |
| `2DGAMELIB/ShapePartT.cs` | Text-rendering shape |
| `2DGAMELIB/CurveOutline.cs` | Cardinal spline curve data |
| `2DGAMELIB/JointPoint.cs` | Joint anchor point |
| `2DGAMELIB/Joints.cs` | Joint connection management |
| `2DGAMELIB/OrderedDictionary.cs` | Serializable ordered dictionary |
| `2DGAMELIB/Vector2D.cs` | 2D vector struct |
| `2DGAMELIB/Serializer.cs` | BinaryFormatter + JSON serialization |
| `2DGAMELIB/RemappedTypeBinder.cs` | Legacy type name remapping for BinaryFormatter |
| `2DGAMELIB/ObjExtensions.cs` | KeyMap + MigrateKeys |
| `2DGAMELIB/GeometryUtils.cs` | ObjLoad/ObjLoadRaw extension methods |
| `2DGAMELIB/Motion.cs` | Single animation motion |
| `2DGAMELIB/Motions.cs` | Motion collection controller |
| `2DGAMELIB/FpsCounter.cs` | Fixed-timestep FPS lock |
| `SlaveMatrix.Extract/Program.cs` | Asset extraction CLI (BinaryFormatter→JSON/SVG/YAML) |
| `SlaveMatrix/Properties/Resources.resx` | Embedded resource manifest |
| `SlaveMatrix/Properties/Resources.Designer.cs` | Strongly-typed resource accessors |
| `SlaveMatrix/Resources/*` | Raw binary resource files |
| `game_folder/` | Runtime assets (text, bgm, save, config) |
| `Assets/Catalog.yaml` | Generated global catalog |
| `Assets/Parts/{id}/` | Generated per-part SVG+YAML |
