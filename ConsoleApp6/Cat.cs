namespace ConsoleApp6
{
    public class Cat : Animal
    {
        private static int numberOfLives = 9;
        public Cat(string name, float weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }
    }
}
