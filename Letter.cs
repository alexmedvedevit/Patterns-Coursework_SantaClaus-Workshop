namespace SantasFactory;

public class Letter
{
    private Child Sender { get; set; }
    public Child GetSender()
    {
        return this.Sender;
    }
    
    private IGivesPresents Addressee { get; set; }

    public IGivesPresents GetAddressee()
    {
        return this.Addressee;
    }
    
    private string Text{ get; set; }

    public Letter(Child sender, IGivesPresents addressee)
    {
        this.Sender = sender;
        this.Addressee = addressee;

        this.Text = "Dear "+this.Addressee.Name+"! This year I want a "+this.Sender.GetWish()+
                    ". With best regards, "+this.Sender.GetName()+" from "+this.Sender.GetAddress()+ ", "+this.Sender.GetAge()+" years old.";
        Console.WriteLine(this.Text);
        this.Addressee.MakeADecision(this);
    }
}