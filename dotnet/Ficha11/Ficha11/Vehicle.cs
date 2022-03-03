namespace Ficha11
{
    public abstract class Vehicle
    {
        private Travel travel;
        private string color;
        private float weigth;
        private string brand;
        private string model;
        private Engine engine;

        public Vehicle(Travel travel, string color, float weigth, string brand, string model, Engine engine)
        {
            this.travel = travel;
            this.color = color;
            this.weigth = weigth;
            this.brand = brand;
            this.model = model;
            this.engine = engine;
        }

        public Travel Travel { get { return travel; } set { travel = value; } }
        public string Color { get { return color; } set { color = value; } }
        public float Weigth { get { return weigth; } set { weigth = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }

        public abstract void Start(); 
    }
}
