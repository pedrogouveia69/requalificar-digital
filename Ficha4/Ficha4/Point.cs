namespace Ficha4
{
    public class Point
    {
        private double x;
        private double y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void setXandY(double x, double y) { 
            this.x = x;
            this.y = y;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public double getDistanceTo(Point other) 
        {
            return Math.Sqrt(Math.Pow((other.x - this.x), 2) + Math.Pow((other.y - this.y), 2));
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }
    }
}
