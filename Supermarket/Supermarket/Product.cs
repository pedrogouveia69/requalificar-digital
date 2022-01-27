namespace Supermarket
{
    public class Product
    {
        public int id { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Product(int id, string description, double price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }
    }
}
