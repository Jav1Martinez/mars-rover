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

            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    direction = RotateToLeft(direction);
                }
                else
                {
                    direction = "E";
                }
            }

            return "0:0:" + direction[0];
        }

        private string RotateToLeft(string direction)
        {
            return positionMapping[direction].left;
        }
    }
}