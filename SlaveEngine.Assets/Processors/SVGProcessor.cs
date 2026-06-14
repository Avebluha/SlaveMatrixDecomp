namespace SlaveEngine.Assets.Processors;

[AssetProcessor(typeof(VectorAsset), managedExtensions: [".svg"])]
public sealed class SVGProcessor : AssetProcessor{

    public override Asset Process(AssetFileInfo fileInfo, byte[] data)
    {
        throw new NotImplementedException();
    }
}