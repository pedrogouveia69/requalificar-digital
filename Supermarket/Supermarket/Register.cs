namespace Supermarket
{
    public class Register
    {
        private RegisterType type;
        private bool isOpen;
        private Employee? employee;
        private List<Costumer> waitingLine;
        private List<string> log;
        private double sumEuros;

        public Register(RegisterType type)
        {
            waitingLine = new List<Costumer>();
            log = new List<string>();
        }

        public RegisterType Type { get { return type; } }
        public bool IsOpen { get { return isOpen; } set { isOpen = value; } }
        public List<Costumer> WaitingLine { get { return waitingLine; } }
        public Employee? Employee { get { return employee; } set { employee = value; } }
        public List<string> Log { get { return log; } }
        public double SumEuros { get { return sumEuros; } set { sumEuros = value; } }

    
        public void ChangeEmployee(Employee newEmployee)
        {
            log.Add(employee.Name + " left");
            employee = newEmployee;
            log.Add(newEmployee.Name + " took over");
        }
    }
}
