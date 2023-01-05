namespace SantasFactory.Presents.Factories;

public abstract class PresentFactory
{
    public abstract AbstractPresent CreatePresent(Letter letter);
}