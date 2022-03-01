public abstract class Animal
{
    public string Name { get; set; }
    public int MaxHungerLevel { get; set; }
    public int CurrentHungerLevel { get; set; }
    public bool EatsMeat { get; set; }
    public bool EatsLeaf { get; set; }

    public bool IsHungry()
    {
        return CurrentHungerLevel == MaxHungerLevel - 1;
    }

}
