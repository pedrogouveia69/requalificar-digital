using ConsoleApp6;

var bobby = new Dog("Bobby", 12.3f, 1);
var bobby2 = new Dog("Bobby 2", 12.3f, 1);
var cat_bobby = new Cat("Cat Bobby", 12.3f, 1);

var animalShelter = new AnimalShelter(5, 5);

Console.WriteLine(animalShelter.Register(bobby));
Console.WriteLine(animalShelter.Register(cat_bobby));
Console.WriteLine(animalShelter.Register(bobby2));
Console.WriteLine(animalShelter.Adopt(cat_bobby.Id));

// re-register with same id
Console.WriteLine(animalShelter.Register(cat_bobby));

Console.WriteLine(bobby.Teach(Trick.Fetch));


void ThrowStick()
{
    foreach (var dog in animalShelter.Dogs)
    {
        if (dog.Tricks.Contains(Trick.Fetch))
        {
            Console.WriteLine(dog.Do(Trick.Fetch));
        }
    }
}

ThrowStick();
