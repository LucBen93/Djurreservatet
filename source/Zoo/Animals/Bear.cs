public class Bear : Omnivore
{
    public Bear(string name)
    {
        base.Name = name;
        base.MaxHungerLevel = 3;
    }
}