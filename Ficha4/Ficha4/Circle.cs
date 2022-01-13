namespace Ficha4
{
    public class Circle : Shape
    {
        private double radius;

        public Circle() : base()
        {
            radius = 0;
        }

        public Circle(Point position, double radius) : base(position)
        { 
            this.radius = radius;
        }

        public double Radius { get { return radius; } set { radius = value; } }

        public override double getArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return Position.ToString() + " radius: " + radius;
        }
    }

}