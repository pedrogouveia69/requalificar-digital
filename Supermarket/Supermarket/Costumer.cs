namespace Supermarket
{
    public class Costumer
    {
        private int nif;
        private bool isPregnant;
        private List<Product> shoppingCart;

        public Costumer(int nif, bool isPregnant)
        {
            this.nif = nif;
            this.isPregnant = isPregnant;
            shoppingCart = new List<Product>();
        }

        public bool IsPregnant { get { return isPregnant; } }
        public List<Product> ShoppingCart { get { return shoppingCart; } }

        public void AddToShoppingCart(Product product)
        {
            shoppingCart.Add(product);
            Console.WriteLine(product.Description + " added to shopping cart");
        }

        public void WaitInLine(Register register)
        {
            if (!register.IsOpen)
                Console.WriteLine("This register is closed");
            else

                if (this.IsPregnant && register.Type == RegisterType.PRIORITY)
                    register.WaitingLine.Insert(0, this);

                else if (this.ShoppingCart.Count > 10 && register.Type == RegisterType.EXPRESS)
                    Console.WriteLine("This register is only for people with 10 products or less.");

                else
                    register.WaitingLine.Add(this);
        }
    }
}
