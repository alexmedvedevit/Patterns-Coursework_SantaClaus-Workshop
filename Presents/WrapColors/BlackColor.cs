namespace SantasFactory.Presents.WrapColors;

public class BlackColor:IWrapColor
{
    private string Name;

    public BlackColor()
    {
        this.Name = "Black";
    }

    public string GetName()
    {
        return this.Name;
    }
}