namespace SlaveEngine.Assets;

public abstract class Asset {
    public Guid Guid { get; private set; }
    public AssetFileInfo FileInfo { get; private set; }
}