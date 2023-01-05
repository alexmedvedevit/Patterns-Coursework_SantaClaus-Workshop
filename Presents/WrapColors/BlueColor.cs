namespace SantasFactory.Presents.WrapColors;

public class BlueColor:IWrapColor
{
    private string Name;

    public BlueColor()
    {
        this.Name = "Blue";
    }

    public string GetName()
    {
        return this.Name;
    }
}