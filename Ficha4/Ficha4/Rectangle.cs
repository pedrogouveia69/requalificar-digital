namespace Ficha4
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle() : base()
        {
            height = 0;
            width = 0;
        }

        public Rectangle(Point position, double height, double width) : base(position)
        {
            this.height = height;
            this.width = width;
        }

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
            Point bottomLeftPoint = new Point(Position.X, Position.Y - height);
            Point bottomRightPoint = new Point(bottomLeftPoint.X + width, bottomLeftPoint.Y);

            if 
            (
                (p.X < bottomLeftPoint.X || p.X > bottomRightPoint.X) ||
                (p.Y < bottomLeftPoint.Y || p.Y > Position.Y)
            )
            {
                return false;
            }
            return true;
        }
    }
}
