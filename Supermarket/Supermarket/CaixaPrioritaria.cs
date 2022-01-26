namespace Supermarket
{
    public class CaixaPrioritaria : Caixa
    {
        public override void AddToWaitingLine(Costumer costumer)
        {
            if (!IsOpen)
                Console.WriteLine("Esta caixa está fechada.");
            else
            {
                if (costumer.IsPregnant)
                    WaitingLine.Insert(0, costumer);
                else
                    WaitingLine.Add(costumer);
            }
        }
    }
}
