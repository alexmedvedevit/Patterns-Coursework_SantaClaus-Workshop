namespace SantasFactory.Presents.WrapColors;

public class GreenColor:IWrapColor
{
    private string Name;

    public GreenColor()
    {
        this.Name = "Green";
    }

    public string GetName()
    {
        return this.Name;
    }
}