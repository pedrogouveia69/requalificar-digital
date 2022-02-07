namespace Pedro_Gouveia_2019419
{
    public class Customer
    {
        private string name;
        private bool member;
        private MemberType memberType;

        public Customer(string name)
        {
            this.name = name;
        }
        public string Name { get { return name; } }
        public bool Member { get { return member; } set { member = value; } }
        public MemberType MemberType { get { return memberType; } set { memberType = value; } }

        public double PrecoComDesconto(double preco)
        {
            switch (memberType)
            {
                case MemberType.Premium: 
                    preco -= preco * 0.20;
                    break;
                case MemberType.Gold:
                    preco -= preco * 0.15;
                    break;
                case MemberType.Silver:
                    preco -= preco * 0.10;
                    break;        
            }
            return preco;
        }

    }
}
