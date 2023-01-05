namespace SantasFactory.Presents.WrapMaterials;

public class TissueMaterial:IWrapMaterial
{
    private string Name;

    public TissueMaterial()
    {
        this.Name = "Tissue";
    }

    public string GetName()
    {
        return this.Name;
    }
}