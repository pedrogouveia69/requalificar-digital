namespace Movable
{
    internal class MovablePoint : IMovable
    {
        protected int x;
        protected int y;
        protected int xSpeed;
        protected int ySpeed;

        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public void MoveUp()
        {
            y+=ySpeed;
        }

        public void MoveDown()
        {
            y-=ySpeed;
        }

        public void MoveLeft()
        {
            x-=xSpeed;
        }

        public void MoveRight()
        {
            x+=xSpeed;
        }

        public override string ToString()
        {
            return String.Format("X: {0}, Y: {1}", x, y);
        }
    }
}
