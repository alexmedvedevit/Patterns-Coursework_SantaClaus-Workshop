using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory;

public class BadPresent:AbstractPresent
{
    public BadPresent(string aContentHeWanted)
    {
        this.PresentContent = "Lump of coal";
        this.WrapColor = new BlackColor();
        this.WrapMaterial = new ParchmentMaterial();
        Console.WriteLine("No "+aContentHeWanted+" for you this year!");
    }
}