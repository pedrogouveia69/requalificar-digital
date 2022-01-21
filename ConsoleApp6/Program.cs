using ConsoleApp6;

var bobby = new Dog(1, "bobby", 12.3f, 1);

var animalShelter = new AnimalShelter(1, 5);

Console.WriteLine(animalShelter.Register(bobby));
Console.WriteLine(animalShelter.Adopt(1));
