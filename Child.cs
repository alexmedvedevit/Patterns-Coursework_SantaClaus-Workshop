using System.Security.Cryptography;

namespace SantasFactory;

public class Child
{
    private string Name { get; set; }
    public string GetName()
    {
        return this.Name;
    }

    private double Age { get; set; }
    public double GetAge()
    {
        return this.Age;
    }
    private string Address { get; set; }
    public string GetAddress()
    {
        return this.Address;
    }
    
    private bool IsBehaviourGood { get; set; }
    public bool GetBehaviour()
    {
        return this.IsBehaviourGood;
    }
    
    private string Wish { get; set; }
    public string GetWish()
    {
        return this.Wish;
    }

    public Child(string name, double age, string address, bool behaviour, string wish)
    {
        this.Name = name;
        this.Age = age;
        this.Address = address;
        this.IsBehaviourGood = behaviour;
        this.Wish = wish;
    }

    public void WriteALetter(IGivesPresents addressee)
    {
        Letter letter = new Letter(this, addressee);
    }
}