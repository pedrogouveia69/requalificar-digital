namespace Supermarket
{
    public class Product
    {
        public string description { get; set; }
        public double price { get; set; }

        public Product(string description, double price)
        {
            this.description = description;
            this.price = price;
        }
    }
}
