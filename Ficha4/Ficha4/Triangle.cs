namespace Ficha4
{
    internal class Triangle
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
            return this.b.getDistanceTo(this.c);
        }

        public double getTriangleHeigth()
        {
            return this.b.getDistanceTo(this.a);
        }

        public double calculateTriangleArea()
        {
            return getTriangleBase() * getTriangleHeigth() / 2;
        }
    }

}
