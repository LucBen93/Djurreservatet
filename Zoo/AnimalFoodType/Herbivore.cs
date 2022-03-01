public class Herbivore : Animal
{
    public Herbivore()
    {
        base.EatsMeat = false;
        base.EatsLeaf = true;
    }
}