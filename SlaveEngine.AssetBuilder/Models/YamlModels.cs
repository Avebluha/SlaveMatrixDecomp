namespace SlaveEngine.AssetBuilder.Models;

public class PartYaml {
    public string Id { get; set; } = "";
    public string OriginalKey { get; set; } = "";
    public string Resource { get; set; } = "";
    public int MorphX { get; set; }
    public int MorphY { get; set; }
    public List<VariantYaml>? Variants { get; set; }
    public List<FieldYaml>? Fields { get; set; }
    public List<JointYaml>? Joints { get; set; }
}

public class VariantYaml {
    public int X { get; set; }
    public int Y { get; set; }
    public string File { get; set; } = "";
}

public class FieldYaml {
    public string Name { get; set; } = "";
}

public class JointYaml {
    public List<float>? Position { get; set; }
}

public class CatalogYaml {
    public List<CatalogEntry>? Parts { get; set; }
}

public class CatalogEntry {
    public string Id { get; set; } = "";
    public string Path { get; set; } = "";
}
