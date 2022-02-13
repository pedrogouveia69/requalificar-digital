namespace ExsUnipartner
{
    public abstract class Veiculo
    {
        public bool Estado { get; set; }
        public int velocidadeAtual;

        public Veiculo(bool estado, int velocidadeAtual)
        {
            Estado = estado;
            this.velocidadeAtual = velocidadeAtual;
        }

        public virtual string Ligar()
        {
            Estado = true;
            return "Ligado com sucesso";
        }
        public string Desligar()
        {
            Estado = false;
            return "Desligado com sucesso";
        }

        public abstract int VelocidadeAtual();
    }
}
