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
            _coordenateY += 1;
            
            if (_coordenateY >= _grid.getHeight())
            {
                _coordenateY = 0;
            }
        }
    }
}