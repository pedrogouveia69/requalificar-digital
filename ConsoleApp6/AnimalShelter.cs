namespace ConsoleApp6
{
    public class AnimalShelter
    {
        private List<Dog> dogs;
        private int dogCapacity;
        private List<Cat> cats;
        private int catCapacity;
        public AnimalShelter(int dogCapacity, int catCapacity)
        {
            this.dogCapacity = dogCapacity;
            this.catCapacity = catCapacity;

            dogs = new List<Dog>();
            cats = new List<Cat>();
        }

        public List <Dog> Dogs { get { return dogs; } }
        public string Register(Animal animal)
        {
            if (animal.Id == 0)
                return "Id cannot be 0";

            foreach (var dog in dogs)
            {
                if (dog.Id == animal.Id)
                    return "An animal with that ID is already registered.";
            }

            foreach (var cat in cats)
            {
                if (cat.Id == animal.Id)
                    return "An animal with that ID is already registered.";
            }

            if (animal is Dog)
            {
                if (dogCapacity == 0)
                    return "The shelter cannot take in any more dogs.";

                dogs.Add((Dog)animal);
                dogCapacity--;
                return "Dog registerd with success.";
            }

            if (animal is Cat)
            {
                if (catCapacity == 0)
                    return "The shelter cannot take in any more cats.";

                cats.Add((Cat)animal);
                catCapacity--;
                return "Cat registerd with success.";
            }

            return "This shelter only takes in dogs and cats.";
        }

        public string Adopt(int animalId)
        {
            foreach (var dog in dogs)
            {
                if (dog.Id == animalId)
                    return dog.Name + " was adopted!";
            }

            foreach (var cat in cats)
            {
                if (cat.Id == animalId)
                    return cat.Name + " was adopted!";
            }

            return "No animal matches the given Id";
        }
    }
}
