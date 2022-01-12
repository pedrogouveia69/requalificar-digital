namespace ExsUnipartner
{
    public class Cliente : Utilizador
    {
        private int numCliente;
        public Cliente(string nome, string password, int numCliente) : base(nome, password)
        { 
            this.numCliente = numCliente;
        }

        public void comprar() { }
    }
}
