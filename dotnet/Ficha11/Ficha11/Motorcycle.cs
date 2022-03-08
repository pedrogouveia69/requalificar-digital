using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha11
{
    public class Motorcycle : Vehicle
    {
        private MotorcycleType type;
        private int topSpeed;

        public Motorcycle(Travel travel, string color, float weigth, string brand, string model, Engine engine, MotorcycleType type, int topSpeed) 
            : base(travel, color, weigth, brand, model, engine)
        {
            this.type = type;
            this.topSpeed = topSpeed;
        }

        public MotorcycleType Type { get { return type; } set { type = value; } }
        public int TopSpeed { get { return topSpeed; } set { topSpeed = value; } }

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
