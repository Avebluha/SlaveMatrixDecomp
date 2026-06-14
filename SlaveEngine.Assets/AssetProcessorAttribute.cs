namespace SlaveEngine.Assets;

public class AssetProcessorAttribute : Attribute {
    public Type ManagedType { get; init; }
    public string[] ManagedExtensions { get; init; }
    
    public AssetProcessorAttribute(Type managedType, string[] managedExtensions)
    {
        ManagedType = managedType ?? throw new ArgumentNullException(nameof(managedType));

        // Validate that the provided type is Asset or a subclass of Asset
        if (managedType != typeof(Asset) && !managedType.IsSubclassOf(typeof(Asset)))
            throw new ArgumentException($"The type '{managedType.FullName}' must derive from '{typeof(Asset).FullName}'.", nameof(managedType));

        // Validate extensions: non-null, non-empty, normalized, start with '.', no whitespace, unique
        if (managedExtensions == null)
            throw new ArgumentNullException(nameof(managedExtensions));

        if (managedExtensions.Length == 0)
            throw new ArgumentException("At least one file extension must be provided.", nameof(managedExtensions));

        var normalized = new List<string>(managedExtensions.Length);
        foreach (var ext in managedExtensions)
        {
            if (string.IsNullOrWhiteSpace(ext))
                throw new ArgumentException("Extensions must be non-empty strings.", nameof(managedExtensions));

            var e = ext.Trim();

            // allow either "png" or ".png" as input, normalize to lowercase with leading dot
            if (!e.StartsWith('.'))
                e = "." + e;

            if (e.Length < 2)
                throw new ArgumentException($"Invalid extension '{ext}'.", nameof(managedExtensions));

            if (e.Any(char.IsWhiteSpace))
                throw new ArgumentException($"Extension '{ext}' contains whitespace.", nameof(managedExtensions));

            normalized.Add(e.ToLowerInvariant());
        }

        // ensure uniqueness
        ManagedExtensions = normalized.Distinct().ToArray();
    }
}