using SantasFactory.Presents.Factories;
using SantasFactory.Presents.WrapColors;
using SantasFactory.Presents.WrapMaterials;

namespace SantasFactory;

public class EasternSender:IGivesPresents
{
    public string Name { get; set; }

    public EasternSender(string name)
    {
        this.Name = name;
    }

    public AbstractPresent MakeADecision(Letter letter)
    {
        Console.WriteLine(this.Name + " looked at the letter and decided to give a present " +letter.GetSender().GetName()+" anyway. He is "+this.Name+" after all! С Новым годом!");
        GoodPresentFactory goodPresentFactory = new GoodPresentFactory();
        return goodPresentFactory.CreatePresent(letter);
    }
}