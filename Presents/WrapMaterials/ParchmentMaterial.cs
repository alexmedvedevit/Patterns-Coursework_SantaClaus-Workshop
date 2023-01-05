namespace SantasFactory.Presents.WrapMaterials;

public class ParchmentMaterial:IWrapMaterial
{
    private string Name;

    public ParchmentMaterial()
    {
        this.Name = "Parchment";
    }

    public string GetName()
    {
        return this.Name;
    }
}