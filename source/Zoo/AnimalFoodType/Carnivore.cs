public class Carnivore : Animal
{
    public Carnivore()
    {
        base.EatsMeat = true;
        base.EatsLeaf = false;
    }
}