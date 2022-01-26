namespace Supermarket
{
    public class Employee : Person
    {
        private int id;

        public Employee(string name, int id) : base (name)
        {
            this.id = id;
        }

        public void ScanProducts(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine (product.description + " scanned.");
            }
        }
    }
}
