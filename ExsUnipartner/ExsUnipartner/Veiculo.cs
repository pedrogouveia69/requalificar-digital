namespace ExsUnipartner
{
    public abstract class Veiculo
    {
        private bool _estado;

        public string ligar()
        {
            _estado = true;
            return "Ligado com sucesso";
        }
        public string desligar()
        {
            _estado = false;
            return "Desligado com sucesso";
        }
        public bool estado()
        {
            return _estado;
        }
        public abstract int velocidadeAtual();
    }
}
