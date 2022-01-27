namespace Supermarket
{
    public class Employee
    {
        private int id;
        private string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name { get { return name; } }

        public void OpenRegister(Register Register)
        {
            Register.IsOpen = true;
            Register.Employee = this;

            Register.Log.Add("Opened by " + this.name);
        }

        public void CloseRegister(Register Register)
        {
            Register.IsOpen = false;
            Register.WaitingLine.Clear();
            Register.Employee = null;

            Register.Log.Add("Closed by " + this.Name);
        }

        public void ScanProducts(List<Product> products)
        {
            if (products.Count > 0)
            {
                double sum = 0;
                foreach (var product in products)
                {
                    sum += product.price;
                    Console.WriteLine(product.description + " scanned.");
                }
                Console.WriteLine("Total: " + sum);
            }
        }
    }
}
