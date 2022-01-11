namespace ExsUnipartner
{
    public class Curso : ICurso
    {
        private string nomeCurso;
        private List<string> disciplinas;
        private int anoCurso;
        private string resumoMateria;

        public Curso(string nomeCurso, List<string> disciplinas, int anoCurso, string resumoMateria)
        {
            this.nomeCurso = nomeCurso;
            this.disciplinas = disciplinas;
            this.anoCurso = anoCurso;
            this.resumoMateria = resumoMateria;
        }

        public string obterNomeCurso() { return nomeCurso; }
        public List<string> obterDisciplinas() { return disciplinas; }
        public int obterAnoCurso() { return anoCurso; }
        public string obterResumoMateria() { return resumoMateria; }
    }
}
