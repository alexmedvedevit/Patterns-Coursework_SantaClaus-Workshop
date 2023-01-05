using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory;

public abstract class AbstractPresent
{
    protected string PresentContent { get; set; }
    public string GetContent()
    {
        return this.PresentContent;
    }
    protected IWrapMaterial WrapMaterial { get; set; }  //Материал обертки

    public IWrapMaterial GetMaterial()
    {
        return this.WrapMaterial;
    }
    protected IWrapColor WrapColor { get; set; } // Цвет обертки
    public IWrapColor GetColor()
    {
        return this.WrapColor;
    }
}