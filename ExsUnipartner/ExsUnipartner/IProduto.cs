namespace ExsUnipartner
{
    public interface IProduto
    {
        public string detalhesProduto();
        public double precoProduto();
        public double precoComDesconto();
        public bool estaDisponivel();
        public int quantidadeStock();
    }
}
