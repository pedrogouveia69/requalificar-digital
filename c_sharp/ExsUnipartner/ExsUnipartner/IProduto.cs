namespace ExsUnipartner
{
    public interface IProduto
    {
        public string Detalhes { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public int Stock { get; set; }
        public bool Disponivel { get; }

    }
}
