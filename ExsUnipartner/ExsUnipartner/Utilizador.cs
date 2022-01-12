namespace ExsUnipartner
{
    public class Utilizador
    {
        private string nome;
        private string password;

        public Utilizador(string nome, string password)
        {
            this.nome = nome;
            this.password = password;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Password { get { return password; } set { password = value; } }   
        public void login()
        {

        }
    }
}
