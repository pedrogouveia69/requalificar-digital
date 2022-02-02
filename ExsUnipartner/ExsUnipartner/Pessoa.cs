namespace ExsUnipartner
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Num_bi { get; set; }

        public Pessoa(string nome, int num_bi)
        {
            Nome = nome;
            Num_bi = num_bi;
        }
    }
}
