namespace GenioLampada
{
    public class MagicLamp
    {
        private int numberOfGenies;
        private int rechargeCounter;
        private int startingNumberOfGenies;

        public GoodGenie GoodGenie { get; } 
        public BadGenie BadGenie { get; }
        public  Demon Demon { get; }

        public MagicLamp(int numberOfGenies)
        {
            this.numberOfGenies = numberOfGenies;
            startingNumberOfGenies = numberOfGenies;
            GoodGenie = new GoodGenie();
            BadGenie = new BadGenie();
            Demon = new Demon();
        }

        public int NumberOfGenies { get { return numberOfGenies; } }
        public int RechargeCounter { get { return rechargeCounter; } }

        public void rub(int times, int numberOfWishes) 
        {
            if (numberOfGenies > 0)
            {
                if (times % 2 != 0)
                {
                    GoodGenie.AvailableWishes = numberOfWishes;
                    Console.WriteLine("Good Genie:");
                    while (numberOfWishes > 0)
                    {
                        GoodGenie.grantWish();
                        GoodGenie.AvailableWishes--;
                        numberOfWishes--;
                    }
                }
                else
                {
                    if (BadGenie.WishGranted == false)
                    {
                        Console.WriteLine("Bad Genie:");
                        BadGenie.grantWish();
                        BadGenie.WishGranted = true;
                    }
                    else
                    {
                        Console.WriteLine("Bad Genie already granted his wish.");
                    }
                }
                numberOfGenies--;
            }
            else 
            {
                Console.WriteLine("Demon:");
                while (numberOfWishes > 0)
                {
                    Demon.grantWish();
                    numberOfWishes--;
                }
            }
        }
        public void recharge() 
        {
            Console.WriteLine("Lamp recharged.");
            numberOfGenies = startingNumberOfGenies; 
            rechargeCounter++;
        }
    }
}
