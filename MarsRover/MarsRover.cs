using System.Collections.Generic;

namespace MarsRover
{
    public class MarsRover
    {
        Dictionary<string, dynamic> positionMapping = new Dictionary<string, dynamic>()
        {
            {"NORTH", new {left = "WEST", right = "EAST"}},
            {"WEST", new {left = "SOUTH", right = "NORTH"}},
            {"SOUTH", new {left = "EAST", right = "WEST"}},
            {"EAST", new {left = "NORTH", right = "SOUTH"}},
        };

        public string Execute(string commands)
        {
            var direction = "NORTH";
            var coordinateX = 0;
            var coordinateY = 0;

            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    direction = RotateToLeft(direction);
                }
                else if (command == 'R')
                {
                    direction = RotationToRight(direction);
                }
                else
                {
                    coordinateY += 1;
                }
            }

            return coordinateX + ":" + coordinateY + ":" + direction[0];
        }

        private string RotateToLeft(string direction)
        {
            return positionMapping[direction].left;
        }
        
        private string RotationToRight(string direction)
        {
            return positionMapping[direction].right;
        }
    }
}