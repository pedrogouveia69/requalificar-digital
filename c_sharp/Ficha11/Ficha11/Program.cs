using Ficha11;

var engine = new Engine(300, 2400, 300);
var vehicleTest = new VehicleTest(new Car(Travel.LAND, "red", 2000, "nissan", "micra", engine, 4, 4));

vehicleTest.Vehicle.Drive();
