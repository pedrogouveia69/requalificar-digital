namespace ExsUnipartner
{
    public class Produto : IProduto
    {
        private string detalhes;
        private double preco;
        private float desconto;
        private int stock;

        public Produto(string detalhes, double preco, float desconto, int stock)
        {
            this.detalhes = detalhes;
            this.preco = preco;
            this.desconto = desconto;
            this.stock = stock;
        }
        
        public string detalhesProduto() { return detalhes; }
        public double precoProduto() { return preco; }
        public double precoComDesconto() { return preco * desconto; }
        public bool estaDisponivel() { return stock > 0 ? true : false; }
        public int quantidadeStock() 
        { 
            if (estaDisponivel())
            {
                return stock;
            }
            return 0;
        }
    }
}
