namespace ExsUnipartner
{
    public class Navio : Veiculo
    {
        public Navio(bool estado, int velocidadeAtual) : base(estado, velocidadeAtual)
        {

        }

        public override string Ligar()
        {
            Estado = true;
            return "O navio doi ligado";
        }

        public override int VelocidadeAtual()
        {
            return velocidadeAtual;
        }

    }
}
