using SantasFactory;

var easternChildren = new List<Child>();
easternChildren.Add(new Child("Ivan", 10, "Arkhangelsk, Russia", true, "PlayStation 5"));
easternChildren.Add(new Child("Anastasia", 8, "Brest, Belarus", false, "Sack of potatoes"));
easternChildren.Add(new Child("Xiao", 17, "Beijing, China", true, "Catwife"));

var westernChildren = new List<Child>();
westernChildren.Add(new Child("Svante", 9, "Stockholm, Sweden", true, "Puppy"));
westernChildren.Add(new Child("Mykola", 14, "Lviv, Ukraine", false, "Horilka"));
westernChildren.Add(new Child("Jane", 11, "Austin, Texas", true, "Cowboy Hat"));

IGivesPresents dedMoroz = new EasternSender("Ded Moroz"),
    santaClaus = new WesternSender("Santa Claus");

foreach (var child in westernChildren)
{
    child.WriteALetter(santaClaus);
    Console.WriteLine("////////////////////////////");
}

foreach(var child in easternChildren)
{
    child.WriteALetter(dedMoroz);
    Console.WriteLine("////////////////////////////");
}


