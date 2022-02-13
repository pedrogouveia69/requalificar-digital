namespace ExsUnipartner
{
    public class Cliente : Utilizador
    {
        public int NumCliente { get; set; }
        public Cliente(string nome, string password, int numCliente) : base(nome, password)
        { 
            NumCliente = numCliente;
        }

        public void Comprar() { }
    }
}
