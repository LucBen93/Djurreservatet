public class Omnivore : Animal
{
    public Omnivore()
    {
        base.EatsMeat = true;
        base.EatsLeaf = true;
    }
}