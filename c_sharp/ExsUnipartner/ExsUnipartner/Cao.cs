namespace ExsUnipartner
{
    public class Cao
    {
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public float Weigth { get; set; }
        public bool IsObese { get { return Weigth > 20 ? true : false; } }

        public Cao(string birthDate, string name, float weigth)
        {
            BirthDate = birthDate;
            Name = name;
            Weigth = weigth;
        }
    }
}
