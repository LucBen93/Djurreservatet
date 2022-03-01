public class Elephant : Herbivore
{
    public Elephant(string name)
    {
        base.Name = name;
        base.MaxHungerLevel = 10;
    }
}