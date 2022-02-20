﻿namespace MarsRover
{
    public class MarsRover
    {
        public string Execute(string command)
        {
            var direction = "NORTH";
            var position = "0:0:E";

            foreach (char c in command)
            {
                if (c == 'L')
                {
                    if (direction == "NORTH")
                    {
                        direction = "WEST";
                        position = "0:0:W";
                    }
                    else if (direction == "WEST")
                    {
                        position = "0:0:S";
                    }
                }
            }

            return position;
        }
    }
}