namespace Supermarket
{
    public class Product
    {
        public int Id { get; }
        public string Description { get; }
        public double Price { get; }

        public Product(int id, string description, double price)
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
