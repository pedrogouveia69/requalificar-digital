namespace ExsUnipartner
{
    public interface ICurso
    {
        public string Nome { get; set; }
        public List<string> Disciplinas { get; set; }
        public int Ano { get; set; }
        public string ResumoMateria { get; set; }
    }
}
