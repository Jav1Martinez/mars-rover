namespace MarsRover
{
    public class MarsRover
    {
        public string Execute(string commands)
        {
            IGrid grid = new Grid();
            ICoordinate coordinate = new Coordinate(grid);
            IDirection direction = new Direction();
            
            var currentDirection = direction.InitialDirection();

            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    currentDirection = direction.RotateToLeft(currentDirection);
                }
                else if (command == 'R')
                {
                    currentDirection = direction.RotateToRight(currentDirection);
                }
                else
                {
                    coordinate.Move(currentDirection);
                }
            }

            return Position(coordinate, currentDirection);
        }
        
        private string Position(ICoordinate coordinate, string currentDirection)
        {
            return coordinate.GetX() + ":" + coordinate.GetY() + ":" + currentDirection[0];
        }
    }
}