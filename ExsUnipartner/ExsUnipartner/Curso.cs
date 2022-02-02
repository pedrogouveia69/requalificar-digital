namespace ExsUnipartner
{
    public abstract class Curso : ICurso
    {
        private string nome;
        private List<string> disciplinas;
        private int ano;
        private string resumoMateria;

        protected Curso(string nome, List<string> disciplinas, int ano, string resumoMateria)
        {
            this.nome = nome;
            this.disciplinas = disciplinas;
            this.ano = ano;
            this.resumoMateria = resumoMateria;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public List<string> Disciplinas { get { return disciplinas; } set { disciplinas = value; } }
        public int Ano { get { return ano; } set { ano = value; } }
        public string ResumoMateria { get { return resumoMateria; } set { resumoMateria = value; } }
    }
}

