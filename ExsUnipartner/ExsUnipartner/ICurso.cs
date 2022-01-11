namespace ExsUnipartner
{
    public interface ICurso
    {
        public string obterNomeCurso();
        public List<string> obterDisciplinas();
        public int obterAnoCurso();
        public string obterResumoMateria();
    }
}
