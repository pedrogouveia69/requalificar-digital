namespace Ficha4
{
    public class Triangle : Shape
    {
        private Point a;
        private Point b;
        private Point c;
        public Triangle()
        {
            a = new Point();
            b = new Point();
            c = new Point();
        }

        public Triangle(Point a, Point b, Point c) { 
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void setABC(Point a, Point b, Point c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Point A { get { return a; } set { a = value; } }
        public Point B { get { return b; } set { b = value; } }
        public Point C { get { return c; } set { c = value; } }

        public double getTriangleBase() 
        {
            return b.getDistanceTo(c);
        }

        public double getTriangleHeigth()
        {
            return b.getDistanceTo(a);
        }

        public override double getArea()
        {
            return getTriangleBase() * getTriangleHeigth() / 2;
        }

        public override double getPerimeter()
        {
            double perimeter = 0;
            perimeter += getTriangleBase();
            perimeter += a.getDistanceTo(b);
            perimeter += b.getDistanceTo(c);

            return perimeter;
        }

    }

}
