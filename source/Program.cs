
Zoo zoo = new();

zoo.AddFood(new Food("Meat", 50));
zoo.AddFood(new Food("Leaf", 50));

zoo.AddAnimal(new Bear("Johannes"));
zoo.AddAnimal(new Coyote("Anders"));
zoo.AddAnimal(new Giraffe("Lucas Henjaminson"));
zoo.AddAnimal(new Elephant("Erik Gryünntder"));
zoo.AddAnimal(new Seal("Alexander Auureema"));

zoo.Run();