namespace Ficha4
{
    public class Figure
    {
        private List<Shape> shapes;

        public Figure()
        {
            shapes = new List<Shape>();
        }

        public Figure(List<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public List<Shape> Shapes { get { return shapes; } set { shapes = value; } }
    }
}
