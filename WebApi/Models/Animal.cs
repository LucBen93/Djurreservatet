namespace WebApi.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MaxHungerLevel { get; set; }
    public int CurrentHungerLevel { get; set; }
    public bool EatsMeat { get; set; }
    public bool EatsLeaf { get; set; }


    public Animal() { }
    public Animal(string name, int maxHungerLevel, int currentHungerLevel, bool eatsMeat, bool eatsLeaf)
    {
        Name = name;
        MaxHungerLevel = maxHungerLevel;
        CurrentHungerLevel = currentHungerLevel;
        EatsMeat = eatsMeat;
        EatsLeaf = eatsLeaf;
    }
}