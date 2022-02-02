namespace ExsUnipartner
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string password, int numFuncionario) : base(nome, password, numFuncionario)
        {

        }

        public void AbrirCaixa() { }
        public void FecharCaiaxa() { }
    }
}
