public class Food
{
    public string Name { get; set; }
    public int Supply { get; set; }
    // public bool IsMeat { get; set; }
    public Food(string name, int supply)
    //bool isMeat
    {
        Name = name;
        Supply = supply;
        // IsMeat = isMeat;
    }
}
