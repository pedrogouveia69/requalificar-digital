namespace ConsoleApp6
{
    public class Dog : Animal
    {
        private List<Trick> tricks;
        public Dog(string name, float weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            tricks = new List<Trick>();
        }

        public List<Trick> Tricks { get { return tricks; } }

        public string Teach(Trick trick)
        {
            foreach (var t in tricks)
            {
                if (t == trick)
                {
                    return Name + " already knows how to " + trick.ToString();
                }
            }
            tricks.Add(trick);
            return Name + " learned a new trick! - " + trick.ToString();
        }

        public string Forget(Trick trick)
        {
            foreach (var t in tricks)
            {
                if (t == trick)
                {
                    tricks.Remove(trick);
                    return Name + " won't remember how to " + trick.ToString() + " anymore";
                }
            }
            return Name + " doesn't know how to " + trick.ToString();
        }

        public string Do(Trick trick)
        {
            foreach (var t in tricks)
            {
                if (t == trick)
                {
                    return Name + " is doing a trick! - " + trick.ToString();
                }
            }
            return Name + " doesn't know how to " + trick.ToString();
        }

    }
}
