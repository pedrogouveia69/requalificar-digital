namespace Pedro_Gouveia_2019419
{
    public class Conta
    {
        private int numConta;
        private string nomeTitular;
        private TipoDeConta tipoConta;
        private double saldo;

        public Conta(int numConta, string nomeTitular, TipoDeConta tipoConta) 
        {
            this.numConta = numConta;
            this.nomeTitular = nomeTitular;
            this.tipoConta = tipoConta;
            saldo = 0;
        }

        public int NumConta { get { return numConta; } }
        public string NomeTitular { get { return nomeTitular; } }
        public double Saldo { get { return saldo; } }

        public void Levantar(double quantia)
        {
            if (saldo >= quantia)
            {
                saldo -= quantia;
                Console.WriteLine("Foi levantada a seguinte quantia: " + quantia);
            }
            else
            {
                Console.WriteLine("Não tem saldo suficiente.");
            }

        }

        public void LevantarLimite(double quantia)
        {
            if (quantia > 300)
            {
                Console.WriteLine("Não é possível levantar mais que 300€.");
            }
            else if (saldo >= quantia)
            {
                saldo -= quantia;
                Console.WriteLine("Foi levantada a seguinte quantia: " + quantia);
            }
            else
            {
                Console.WriteLine("Não tem saldo suficiente.");
            }
        }

        public void Depositar(double quantia)
        {
            saldo += quantia;
            Console.WriteLine("Foi depositada a seguinte quantia: " + quantia);
        }

        public void Transferir(double quantia, Conta conta)
        {
            if (saldo >= quantia)
            {
                saldo -= quantia;
                conta.saldo += quantia;
                Console.WriteLine("Foi transferida a quantia {0} para a conta com o NUM {1}", quantia, conta.NumConta);
            }
            else
            {
                Console.WriteLine("Não tem saldo suficiente.");
            }
        }
    }
}
