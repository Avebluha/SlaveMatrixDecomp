using System;
using System.Collections.Generic;
using System.Reflection;

namespace SlaveEngine.Assets;

public sealed class ResourceManager {

    public ResourceManager(string basePath)
    {
        if (!Path.Exists(basePath))
            throw new DirectoryNotFoundException($"The base path '{basePath}' does not exist.");
        BasePath = basePath;
        Instance = this;
    }

    private AssetProcessor? GetProcessorForExtension(string extension) =>
        _assetProcessors.FirstOrDefault(p => (bool)p.GetType()
            .GetCustomAttribute<AssetProcessorAttribute>()?.ManagedExtensions
            .Contains(extension)
        );

    public static ResourceManager? Instance { get; private set; }

    private List<AssetProcessor> _assetProcessors = new();

    public string BasePath { get; private set; }

    public void Initialize(string basePath)
    {
        ScanDirectory(basePath);
    }

    private void ScanDirectory(string directory)
    {
        var files = Directory.GetFiles(directory);
        foreach (var file in files)
        {
            var ext = Path.GetExtension(file);
            // check if we can process this extension
            var processor = GetProcessorForExtension(ext);
            if (processor == null) continue;

            var name = Path.GetFileNameWithoutExtension(file);
            AssetFileInfo fileInfo = new()
            {
                Filename = name,
                FilePath = file
            };

            processor.Process(fileInfo, File.ReadAllBytes(file));
        }
    }

    public void RegisterProcessor(AssetProcessor processor)
    {
        //make sure the processor for this type isn't already in:
        var ap = _assetProcessors.FirstOrDefault(p => p.GetType() == processor.GetType());
        if (ap == null) _assetProcessors.Add(processor);
    }
}