namespace MarsRover
{
    public class Coordinate: ICoordinate
    {
        private readonly IGrid _grid;
        private int _coordenateX;
        private int _coordenateY;

        public Coordinate(IGrid grid, int coordenateX = 0, int coordenateY = 0)
        {
            _grid = grid;
            _coordenateX = coordenateX;
            _coordenateY = coordenateY;
        }
        
        public int GetX()
        {
            return _coordenateX;
        }

        public int GetY()
        {
            return _coordenateY;
        }

        public void Move(string direction)
        {
            if (direction == Direction.East)
            {
                _coordenateX = (_coordenateX + 1) % _grid.getWidth();
            }
            if (direction == Direction.West)
            {
                _coordenateX = (_coordenateX > 0) ? (_coordenateX - 1) : (_grid.getWidth() - 1);
            }
            if (direction == Direction.North)
            {
                _coordenateY = (_coordenateY + 1) % _grid.getHeight();
            }
            if (direction == Direction.South)
            {
                _coordenateY = (_coordenateY > 0) ? (_coordenateY - 1) : (_grid.getHeight() - 1);
            }
        }
    }
}