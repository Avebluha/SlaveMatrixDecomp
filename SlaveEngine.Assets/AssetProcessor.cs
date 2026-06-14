namespace SlaveEngine.Assets;

public abstract class AssetProcessor {
    public abstract Asset Process(AssetFileInfo fileInfo , byte[] data);
}