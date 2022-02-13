using Ficha4;

namespace Ficha5

{
    public class Figure
    {
        private List<Shape> shapes;

        public Figure()
        {
            shapes = new List<Shape>();
        }
        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }

        public List<Shape> Shapes { get { return shapes; } }
    }
}
