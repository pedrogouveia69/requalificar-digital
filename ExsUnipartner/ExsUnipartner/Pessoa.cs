namespace ExsUnipartner
{
    public class Pessoa
    {
        public string nome { get; set; }
        private int num_bi;

        public Pessoa(string nome, int num_bi)
        {
            this.nome = nome;
            this.num_bi = num_bi;
        }

        public int Num_bi { get { return num_bi; } set { num_bi = value; } } 
    }
}
