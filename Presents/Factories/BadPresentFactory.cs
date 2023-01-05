namespace SantasFactory.Presents.Factories;

public class BadPresentFactory:PresentFactory
{
    public override AbstractPresent CreatePresent(Letter letter)
    {
        BadPresent bp = new BadPresent(letter.GetSender().GetWish());
        Console.WriteLine(letter.GetAddressee().Name+" sent "+letter.GetSender().GetName()+" a "+bp.GetContent()+" in a "+bp.GetColor().GetName()+" "+bp.GetMaterial().GetName()+" wrap.");
        return bp;
    }
}