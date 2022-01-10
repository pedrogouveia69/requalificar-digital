namespace ExsUnipartner
{
    public class Cao
    {
        public string birthDate { get; set; }
        public string nome { get; set; }
        public float weigth { get; set; }

        public Cao (string birthDate, string nome, float weigth)
        {
            this.birthDate = birthDate;
            this.nome = nome;
            this.weigth = weigth;
        }

        public bool isObese()
        {
            // condition ? consequent : alternative
            return weigth > 20 ? true : false;
        }
    }
}
