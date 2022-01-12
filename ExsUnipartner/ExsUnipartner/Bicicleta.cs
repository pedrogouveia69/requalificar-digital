namespace ExsUnipartner
{
    public class Bicicleta : Veiculo
    {
        private int tamanhoRoda;
        public Bicicleta(bool estado, int velocidadeAtual, int tamanhoRoda) : base(estado, velocidadeAtual)
        {
            this.tamanhoRoda = tamanhoRoda;
        }

        public int TamanhoRoda { get { return tamanhoRoda;} set { tamanhoRoda = value;} }

        public override int getVelocidadeAtual()
        {
            return velocidadeAtual;
        }
    }
}
