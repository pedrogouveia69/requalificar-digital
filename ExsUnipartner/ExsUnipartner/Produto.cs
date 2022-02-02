namespace ExsUnipartner
{
    public class Produto : IProduto
    {
        private string detalhes;
        private double preco;
        private double desconto;
        private int stock;

        public Produto(string detalhes, double preco, double desconto, int stock)
        {
            this.detalhes = detalhes;
            this.preco = preco;
            this.desconto = desconto;
            this.stock = stock;
        }
        public string Detalhes { get { return detalhes; } set { detalhes = value; } }

        public double Preco { get { return preco; } set { preco = value; } }

        public double Desconto { get { return desconto; } set { desconto = value; } }

        public int Stock { get { return stock; } set { stock = value; } }

        public bool Disponivel { get { return stock > 0 ? true : false; } }
    }
}
