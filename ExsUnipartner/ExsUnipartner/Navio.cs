namespace ExsUnipartner
{
    public class Navio : Veiculo
    {
        public Navio(bool estado, int velocidadeAtual) : base(estado, velocidadeAtual)
        {
        }

        public override string ligar()
        {
            Estado = true;
            return "Ligado com sucesso";
        }

        public override int getVelocidadeAtual()
        {
            return velocidadeAtual;
        }

    }
}
