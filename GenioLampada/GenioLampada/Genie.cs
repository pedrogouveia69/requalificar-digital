namespace GenioLampada
{ 
    public class Genie
    {
        private int grantedWishes;
        public int GrantedWishes { get { return grantedWishes; } }
        public void grantWish() 
        {
            Console.WriteLine("Wish granted");
            grantedWishes++;
        }

    }
}
