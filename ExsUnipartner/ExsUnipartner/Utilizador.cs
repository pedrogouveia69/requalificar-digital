namespace ExsUnipartner
{
    public class Utilizador
    {
        public string Nome { get; set; }
        public string Password { get; set; }

        public Utilizador(string nome, string password)
        {
            Nome = nome;
            Password = password;
        }

    public void Login() { }

    }
}
