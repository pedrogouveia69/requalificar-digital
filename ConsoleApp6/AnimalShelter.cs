namespace ConsoleApp6
{
    public class AnimalShelter
    {
        private List<Dog> dogs;
        private List<Cat> cats;
        private int dogCapacity;
        private int catCapacity;
        private int animalId;
        public AnimalShelter(int dogCapacity, int catCapacity)
        {
            this.dogCapacity = dogCapacity;
            this.catCapacity = catCapacity;

            dogs = new List<Dog>();
            cats = new List<Cat>();

            animalId = 1;
        }

        public List <Dog> Dogs { get { return dogs; } }
        public List <Cat> Cats { get { return cats; } }

        public int DogCapacity { get { return dogCapacity; } }
        public int CatCapacity { get { return catCapacity;} }

        public string Register(Animal animal)
        {
            if (animal is Dog)
            {
                if (dogCapacity == 0)
                    return "The shelter cannot take in any more dogs.";
                
                if (animal.Id == 0)
                    animal.Id = animalId;

                dogs.Add((Dog)animal);
                dogCapacity--;
                animalId++;
                return animal.Name + " was registerd with the Id: " + animal.Id;
            }

            if (animal is Cat)
            {
                if (catCapacity == 0)
                    return "The shelter cannot take in any more cats.";

                if (animal.Id == 0)
                    animal.Id = animalId;

                cats.Add((Cat)animal);
                catCapacity--;
                animalId++;
                return animal.Name + " was registerd with the Id: " + animal.Id;
            }

            return "This shelter only takes in dogs and cats.";
        }

        public string Adopt(int animalId)
        {
            Animal animal = dogs.Find(dog => dog.Id == animalId);
            if (animal != null)
            {
                dogs.Remove((Dog)animal);
                dogCapacity++;
                return animal.Name + " was adopted!";
            }

            animal = cats.Find(cat => cat.Id == animalId);
            if (animal != null)
            {
                cats.Remove((Cat)animal);
                catCapacity++;
                return animal.Name + " was adopted!";
            }

            return "No animal matches the given Id";
        }
    }
}
