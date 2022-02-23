namespace Movable
{
    internal class MovableCircle : IMovable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int radius, int x, int y, int xSpeed, int ySpeed)
        {
            this.radius = radius;
            center = new MovablePoint(x, y, xSpeed, ySpeed);
        }

        public void MoveUp()
        {
            center.MoveUp();
        }
        public void MoveDown()
        {
            center.MoveDown();
        }
        public void MoveLeft()
        {
            center.MoveLeft();
        }
        public void MoveRight()
        {
            center.MoveRight();
        }
        public override string ToString()
        {
            return String.Format("Radius: {0}, Center: {1}", radius, center.ToString());
        }
    }
}
