namespace GenioLampada
{
    public class MagicLamp
    {
        private int numberOfGenies;
        private int rechargeCounter;
        private Demon demon;

        public MagicLamp(int numberOfGenies) 
        {
            this.numberOfGenies = numberOfGenies;
        }

        public int NumberOfGenies { get { return numberOfGenies; } }
        public int RechargeCounter { get { return rechargeCounter; } set { rechargeCounter = value; } }

        public void rub(int times, int numberOfWishes) 
        {
            if (numberOfGenies > 0)
            {
                if (times % 2 == 0)
                {
                    var genie = new GoodGenie();
                    while (numberOfWishes > 0)
                    {
                        genie.grantWish();
                        numberOfWishes--;
                    }

                }
                else
                {
                    var genie = new BadGenie();
                    genie.grantWish();
                }
                numberOfGenies--;
            }
            else 
            {
                demon.grantWish();
            }

        }

        public void recharge() 
        {

            RechargeCounter++;
        }
    }
}
