using System.Collections.Generic;

namespace MarsRover
{
    public class Direction : IDirection
    {
        private readonly string _direction;

        Dictionary<string, dynamic> directionMapping = new Dictionary<string, dynamic>()
        {
            {"NORTH", new {left = "WEST", right = "EAST"}},
            {"WEST", new {left = "SOUTH", right = "NORTH"}},
            {"SOUTH", new {left = "EAST", right = "WEST"}},
            {"EAST", new {left = "NORTH", right = "SOUTH"}},
        };

        public Direction(string direction = "NORTH")
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