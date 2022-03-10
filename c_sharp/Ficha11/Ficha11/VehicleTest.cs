namespace Ficha11
{
    public class VehicleTest
    {
        private IVehicle vehicle;

        public VehicleTest(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public IVehicle Vehicle { get { return vehicle; } }
    }
}
