using ConsoleApp6;

var bobby = new Dog("bobby", 12.3f, 1);
var cat_bobby = new Cat("cat bobby", 12.3f, 1);

var animalShelter = new AnimalShelter(5, 5);

Console.WriteLine(animalShelter.Register(bobby));

Console.WriteLine(bobby.Do(Trick.Roll));
