namespace ExsUnipartner
{
    internal interface IEmpregado
    {
        public string Empresa { get; }
        public int AnosServico { get; }
        public string NomeCompleto { get; }
        public int Idade { get; }
        public void Trabalhar();
    }
}
