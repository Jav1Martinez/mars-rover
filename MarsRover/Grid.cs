namespace MarsRover
{
    public class Grid : IGrid
    {
        private int height;
        private int width;

        public Grid(int height = 10, int width = 10)
        {
            this.height = height;
            this.width = width;
        }

        public int getHeight()
        {
            return height;
        }

        public int getWidth()
        {
            return width;
        }
    }
}