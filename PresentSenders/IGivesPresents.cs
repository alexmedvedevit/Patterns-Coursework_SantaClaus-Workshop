namespace SantasFactory;

public interface IGivesPresents
{
    string Name { get; set; }
    AbstractPresent MakeADecision(Letter letter);
}