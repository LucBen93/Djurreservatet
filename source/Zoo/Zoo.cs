public class Zoo
{
    public List<Animal> animalList;
    public List<Food> foodList;
    int days = 1;

    public Zoo()
    {
        this.animalList = new();
        this.foodList = new();

        // this.foodSupply.AddRange(foodSupply);
    }

    public void AddAnimal(Animal animal)
    {
        animalList.Add(animal);
    }

    public void AddFood(Food food)
    {
        foodList.Add(food);
    }

    public void Run()
    {
        while (foodList.MinBy(food => food.Supply).Supply != 0)
        {
            Console.Clear();
            IncreaseDay();
            AnimalFeedingLoop();
            PrintFoodSupply();
            CheckFoodSupply(foodList);
            Console.ReadKey();
        }
    }

    private void IncreaseDay()
    {
        System.Console.WriteLine($"Day: {days}");
        days++;
    }

    public void PrintFoodSupply()
    {
        foreach (var food in foodList)
        {
            Console.WriteLine($"Food supply: {food.Name} - {food.Supply}");
        }
    }

    public void AnimalFeedingLoop()
    {
        foreach (var animal in animalList) CheckHunger(animal);

    }

    private void CheckHunger(Animal animal)
    {
        if (animal.IsHungry()) NeedFeeding(animal);
        else DoesNotNeedFeeding(animal);
    }

    public void NeedFeeding(Animal animal)
    {
        Console.WriteLine($"{animal.Name} the {animal.GetType()} needs feeding.");
        FeedAnimal(animal);
    }
    public string FeedingOmnivore()
    {
        var maxFood = foodList.MaxBy(food => food.Supply);
        EatFood(maxFood);
        return maxFood.Name;
    }

    private void FeedAnimal(Animal animal)
    {
        string animalAte = "";
        if (animal is Herbivore) animalAte = EatFood(new Food("Leaf", 1));
        if (animal is Carnivore) animalAte = EatFood(new Food("Meat", 1));
        if (animal is Omnivore) animalAte = FeedingOmnivore();
        ResetHunger(animal);
        System.Console.WriteLine($"{animal.Name} the {animal.GetType()} has eaten. He ate {animalAte}. He liked it.");
    }
    private void ResetHunger(Animal animal) => animal.CurrentHungerLevel = 0;

    private string EatFood(Food chosenFood)
    {
        foodList.Find(food => food.Name == chosenFood.Name).Supply--;
        return chosenFood.Name;
    }

    public void DoesNotNeedFeeding(Animal animal)
    {
        Console.WriteLine($"{animal.Name} the {animal.GetType()} does not need feeding");
        IncreaseHunger(animal);
    }

    private void IncreaseHunger(Animal animal) => animal.CurrentHungerLevel++;

    public void CheckFoodSupply(List<Food> foodList)
    {
        foreach (var food in foodList)
        {
            if (food.Supply == 0)
            {
                Resupply(food);
                Console.WriteLine("Supply empty, resupplying");
            }
        }
    }

    private void Resupply(Food food)
    {
        food.Supply += 50;
    }
}

