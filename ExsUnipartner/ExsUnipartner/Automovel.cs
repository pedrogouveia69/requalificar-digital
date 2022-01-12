namespace ExsUnipartner
{
    public class Automovel : Veiculo
    {
        private string tipoCombustivel;
        public Automovel(bool estado, int velocidadeAtual, string tipoCombustivel) : base(estado, velocidadeAtual)
        {
            this.tipoCombustivel = tipoCombustivel;
        }

        public string TipoCombustivel { get { return tipoCombustivel;} }

        public override int getVelocidadeAtual()
        {
            return velocidadeAtual;
        }
    }
}
