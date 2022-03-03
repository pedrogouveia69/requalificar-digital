namespace Ficha11
{
    public class Car : Vehicle, IVehicle
    {
        private int doors;
        private int seats;

        public Car(Travel travel, string color, float weigth, string brand, string model, Engine engine, int doors, int seats) : base(travel, color, weigth, brand, model, engine)
        {
            this.doors = doors;
            this.seats = seats;
        }

        public int Doors { get { return doors; } set { doors = value; } }
        public int Seats { get { return seats; } set { seats = value; } }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "";
        }
    }
}
