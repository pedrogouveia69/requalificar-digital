namespace GenioLampada
{
    public class MagicLamp
    {
        private int numberOfGenies;
        private int rechargeCounter;
        private GoodGenie goodGenie;
        private BadGenie badGenie;
        private Demon demon;

        private int startingNumberOfGenies;

        public MagicLamp(int numberOfGenies) 
        {
            this.numberOfGenies = numberOfGenies;
            startingNumberOfGenies = numberOfGenies;
            goodGenie = new GoodGenie();
            badGenie = new BadGenie();
            demon = new Demon();
        }

        public string NumberOfGenies { get { return "Available Genies: " + numberOfGenies; } }
        public string RechargeCounter { get { return "The Lamp was recharged " + rechargeCounter + " times."; } }

        public void rub(int times, int numberOfWishes) 
        {
            if (numberOfGenies > 0)
            {
                if (times % 2 != 0)
                {
                    goodGenie.AvailableWishes = numberOfWishes;
                    Console.WriteLine("Good Genie:");
                    while (numberOfWishes > 0)
                    {
                        goodGenie.grantWish();
                        goodGenie.AvailableWishes--;
                        numberOfWishes--;
                    }
                }
                else
                {
                    if (badGenie.WishGranted == false)
                    {
                        Console.WriteLine("Bad Genie:");
                        badGenie.grantWish();
                        badGenie.WishGranted = true;
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
                    demon.grantWish();
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
