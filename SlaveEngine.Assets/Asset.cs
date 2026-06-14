namespace SlaveEngine.Assets;

public abstract class Asset {
    public Guid Guid { get; init; }
    public AssetFileInfo FileInfo { get; init; }
}