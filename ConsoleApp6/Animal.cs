namespace ConsoleApp6
{
    public abstract class Animal
    {
        private int id;
        private string name;
        private float weight;
        private int age;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public float Weight { get { return weight; } set { weight = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
