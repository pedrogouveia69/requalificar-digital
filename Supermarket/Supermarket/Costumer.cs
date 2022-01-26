namespace Supermarket
{
    public class Costumer : Person
    {
        private bool isPregnant;
        private List<Product> shoppingCart;

        public Costumer(string name, bool isPregnant) : base(name)
        {
            this.isPregnant = isPregnant;
            shoppingCart = new List<Product>();
        }

        public bool IsPregnant { get { return isPregnant; } }
        public List<Product> ShoppingCart { get { return shoppingCart; } }

        public void AddToShoppingCart(Product product)
        {
            shoppingCart.Add(product);
            Console.WriteLine(product.description + " added to shopping cart.");
        }
    }
}
