using System.Collections.Generic;

namespace MarsRover
{
    public class Direction : IDirection
    {
        public const string North = "NORTH";
        public const string West = "WEST";
        public const string South = "SOUTH";
        public const string East = "EAST";
            
        private readonly string _direction;

        Dictionary<string, dynamic> directionMapping = new Dictionary<string, dynamic>()
        {
            {North, new {left = West, right = East}},
            {West, new {left = South, right = North}},
            {South, new {left = East, right = West}},
            {East, new {left = North, right = South}},
        };

        public Direction(string direction = North)
        {
            _direction = direction;
        }

        public string InitialDirection()
        {
            return _direction;
        }
        
        public string RotateToLeft(string direction)
        {
            return directionMapping[direction].left;
        }
        
        public string RotateToRight(string direction)
        {
            return directionMapping[direction].right;
        }
    }
}