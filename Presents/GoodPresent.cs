using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory;

public class GoodPresent:AbstractPresent
{
    public GoodPresent(string presentContent, IWrapColor color, IWrapMaterial material)
    {
        this.PresentContent = presentContent;
        this.WrapColor = color;
        this.WrapMaterial = material;
    }
}