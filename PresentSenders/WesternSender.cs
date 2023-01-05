using SantasFactory.Presents.Factories;
using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory;

public class WesternSender:IGivesPresents
{
    public string Name { get; set; }
    
    public WesternSender(string name)
    {
        this.Name = name;
    }

    public AbstractPresent MakeADecision(Letter letter)
    {
        Console.WriteLine(this.Name + " looked at the letter.");
        if (!letter.GetSender().GetBehaviour())
        {
            Console.WriteLine(letter.GetSender().GetName()+" behaved bad this year, so they will receive a bad present for their naughtiness. Merry Christmas!");
            BadPresentFactory badPresentFactory = new BadPresentFactory();
            return badPresentFactory.CreatePresent(letter);
        }
        Console.WriteLine(letter.GetSender().GetName() +
                          " behaved good and polite this year, so they will receive a present they wanted! Merry Christmas!");
        GoodPresentFactory goodPresentFactory = new GoodPresentFactory();
        return goodPresentFactory.CreatePresent(letter);
    }
}