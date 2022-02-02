namespace ExsUnipartner
{
    public class Bicicleta : Veiculo
    {
        public int TamanhoRoda { get; set; }
        public Bicicleta(bool estado, int velocidadeAtual, int tamanhoRoda) : base(estado, velocidadeAtual)
        {
            TamanhoRoda = tamanhoRoda;
        }
        public override int VelocidadeAtual()
        {
            return velocidadeAtual;
        }
    }
}
