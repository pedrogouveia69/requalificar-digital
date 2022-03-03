namespace Ficha11
{
    public class Engine
    {
        private int torque;
        private int displacement;
        private int horsepower;

        public Engine(int torque, int displacement, int horsepower)
        {
            this.torque = torque;
            this.displacement = displacement;
            this.horsepower = horsepower;
        }

        public int Torque { get { return torque; } set { torque = value; } }
        public int Displacement { get { return displacement; } set { displacement = value; } }
        public int Horsepower { get { return horsepower; } set { horsepower = value; } }
    }
}
