namespace ExsUnipartner
{
    public abstract class Veiculo
    {
        private bool estado;
        public int velocidadeAtual;

        public Veiculo(bool estado, int velocidadeAtual)
        {
            this.estado = estado;
            this.velocidadeAtual = velocidadeAtual;
        }

        public bool Estado { get { return estado; } set { estado = value; } }

        public virtual string ligar()
        {
            estado = true;
            return "Ligado com sucesso";
        }
        public string desligar()
        {
            estado = false;
            return "Desligado com sucesso";
        }

        public abstract int getVelocidadeAtual();
    }
}
