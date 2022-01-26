namespace Supermarket
{
    public class Caixa
    {
        private bool isOpen;
        private Employee? employee;
        private List<Costumer>? waitingLine;

        public List<Costumer> WaitingLine { get { return waitingLine; } }
        public bool IsOpen { get { return isOpen; } }

        public Employee? Employee { get { return employee; } }

        public virtual void AddToWaitingLine(Costumer costumer) 
        {
            if (!isOpen)
                Console.WriteLine("Esta caixa está fechada.");
            else
                waitingLine.Add(costumer);
        }

        public virtual void RemoveFromWaitingLine(Costumer costumer)
        {
            waitingLine.Remove(costumer);
        }

        public void Open(Employee employee)
        {
            isOpen = true;
            waitingLine = new List<Costumer>();
            this.employee = employee;
        }

        public void Close()
        {
            isOpen = false;
            waitingLine.Clear();
            employee = null;
        }
    
        public void ChangeEmployee(Employee newEmployee)
        {
            employee = newEmployee;
        }
    }
}
