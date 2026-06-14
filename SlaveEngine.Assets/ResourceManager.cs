using System.Reflection;
using System.Text;

namespace SlaveEngine.Assets;

public sealed class ResourceManager {

    public ResourceManager(string basePath) {
        if (!Path.Exists(basePath))
            throw new DirectoryNotFoundException($"The base path '{basePath}' does not exist.");
        BasePath = basePath;
        Instance = this;
    }

    public static ResourceManager? Instance { get; private set; }
    public string BasePath { get; private set; }

    private readonly List<AssetProcessor> _assetProcessors = new();
    private readonly Dictionary<string, string> _assetIndex = new();
    private readonly Dictionary<string, Asset> _assetCache = new();

    public void Initialize() {
        ScanDirectory(BasePath);
    }

    private void ScanDirectory(string directory) {
        foreach (var file in Directory.GetFiles(directory, "*.spart")) {
            try {
                var id = ReadAssetIdFromSpart(file);
                _assetIndex[id] = file;
            } catch {
                // skip corrupt files
            }
        }
    }

    public T? GetAsset<T>(string id) where T : Asset {
        if (_assetCache.TryGetValue(id, out var cached))
            return (T)cached;

        if (!_assetIndex.TryGetValue(id, out var path))
            return null;

        var ext = Path.GetExtension(path);
        var processor = GetProcessorForExtension(ext);
        if (processor == null)
            return null;

        var fileInfo = new AssetFileInfo {
            Filename = Path.GetFileNameWithoutExtension(path),
            FilePath = path
        };

        var asset = processor.Process(fileInfo, File.ReadAllBytes(path));
        _assetCache[id] = asset;
        return (T)asset;
    }

    public IReadOnlyCollection<string> GetAssetIds() => _assetIndex.Keys;

    public void RegisterProcessor(AssetProcessor processor) {
        if (_assetProcessors.All(p => p.GetType() != processor.GetType()))
            _assetProcessors.Add(processor);
    }

    private AssetProcessor? GetProcessorForExtension(string extension) =>
        _assetProcessors.FirstOrDefault(p => p.GetType()
            .GetCustomAttribute<AssetProcessorAttribute>()?.ManagedExtensions
            .Contains(extension) == true);

    private static string ReadAssetIdFromSpart(string path) {
        using var stream = File.OpenRead(path);
        using var reader = new BinaryReader(stream);
        reader.ReadBytes(8);
        var len = reader.ReadInt32();
        return Encoding.UTF8.GetString(reader.ReadBytes(len));
    }
}
