namespace SantasFactory.Presents.WrapColors;

public class RedColor:IWrapColor
{
    private string Name;

    public RedColor()
    {
        this.Name = "Red";
    }

    public string GetName()
    {
        return this.Name;
    }
}