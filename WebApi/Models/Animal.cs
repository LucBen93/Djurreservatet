namespace WebApi.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Time { get; set; }

    public Animal() { }
    public Animal(string name, int time)
    {
        Name = name;
        Time = time;
    }
}