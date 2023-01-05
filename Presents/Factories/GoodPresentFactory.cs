using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory.Presents.Factories;

public class GoodPresentFactory:PresentFactory
{
    public override AbstractPresent CreatePresent(Letter letter)
    {
        var rnd = new Random();
        IWrapColor[] colors = { new BlueColor(), new RedColor(), new GreenColor() };
        GoodPresent gp = new GoodPresent(letter.GetSender().GetWish(), colors[rnd.Next(0, colors.Length)], new TissueMaterial());
        Console.WriteLine(letter.GetAddressee().Name+" sent "+letter.GetSender().GetName()+" a "+gp.GetContent()+" in a "+gp.GetColor().GetName()+" "+gp.GetMaterial().GetName()+" wrap.");
        return gp;
    }
}