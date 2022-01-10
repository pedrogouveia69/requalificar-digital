using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    public abstract class Shape
    {
        private Point position;

        public Shape()
        {
            position = new Point();
        }

        public Shape(Point position)
        {
            this.position = position;
        }

        public Point Position { get { return position; } set { position = value; } }

        public abstract double getArea();
        public abstract double getPerimeter();
    }
}
