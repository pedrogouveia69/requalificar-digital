namespace GenioLampada
{ 
    public abstract class Genie
    {
        private int grantedWishes;
        public int GrantedWishes { get { return grantedWishes; } }
        public List<string> Wishes { get; set; }

        public Genie()
        {
            Wishes = new List<string>();
        }
        public void grantWish() 
        {
            Console.WriteLine("What is it that you wish?");
            Wishes.Add(Console.ReadLine());
            Console.WriteLine("Wish granted.");
            grantedWishes++;
        }
    }
}
