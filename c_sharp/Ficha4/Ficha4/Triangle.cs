namespace Ficha4
{
    public class Triangle : Shape
    {
        private Point b;
        private Point c;
        
        public Triangle() : base()
        { 
            b = new Point();
            c = new Point();
        }
        
        public Triangle(Point position, Point b, Point c) : base(position)
        { 
            this.b = b;
            this.c = c;
        }

        public void setABC(Point a, Point b, Point c) 
        {
            Position = a;
            this.b = b;
            this.c = c;
        }

        public Point B { get { return b; } set { b = value; } }
        public Point C { get { return c; } set { c = value; } }

        public double getTriangleBase() 
        {
            return b.getDistanceTo(c);
        }

        public double getTriangleHeigth()
        {
            return b.getDistanceTo(Position);
        }

        public override double getArea()
        {
            return getTriangleBase() * getTriangleHeigth() / 2;
        }

        public override double getPerimeter()
        {
            return getTriangleBase() + Position.getDistanceTo(b) + b.getDistanceTo(c);
        }
    }
}
