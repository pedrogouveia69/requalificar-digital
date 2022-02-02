namespace ExsUnipartner
{
    public class Automovel : Veiculo
    {
        public string TipoCombustivel { get; set; }
        public Automovel(bool estado, int velocidadeAtual, string tipoCombustivel) : base(estado, velocidadeAtual)
        {
            TipoCombustivel = tipoCombustivel;
        }

        public override int VelocidadeAtual()
        {
            return velocidadeAtual;
        }
    }
}
