namespace Ficha4
{
    public class Rectangle : Shape
    {
        private Point topLeftPoint;
        private double height;
        private double width;
        public Rectangle()
        {
            topLeftPoint = new Point();
            height = 0;
            width = 0;
        }

        public Rectangle(Point topLeftPoint, double height, double width)
        {
            this.topLeftPoint = topLeftPoint;
            this.height = height;
            this.width = width;
        }

        public Point TopLeftPoint { get { return topLeftPoint; } set { topLeftPoint = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Width { get { return width; } set { width = value; } }

        public override double getArea()
        {
            return height * width;  
        }

        public override double getPerimeter() 
        {
            return (height * 2) + (width * 2); 
        
        }

        public bool contains(Point p)
        {
            Point bottomLeftPoint = new Point(TopLeftPoint.X, topLeftPoint.Y - height);
            Point bottomRightPoint = new Point(bottomLeftPoint.X + width, bottomLeftPoint.Y);

            if 
            (
                (p.X < bottomLeftPoint.X || p.X > bottomRightPoint.X) ||
                (p.Y < bottomLeftPoint.Y || p.Y > TopLeftPoint.Y)
            )
            {
                return false;
            }
            return true;
        }
    }
}
