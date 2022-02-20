namespace MarsRover
{
    public class MarsRover
    {
        public string Execute(string commands)
        {
            var direction = "N";

            foreach (char command in commands)
            {
                if (command == 'L')
                {
                    direction = rotateToLeft(direction);
                }
                else
                {
                    direction = "E";
                }
            }

            return "0:0:"+direction;
        }

        private string rotateToLeft(string direction)
        {
            if (direction == "N")
            {
                return "W";
            }
            else if (direction == "W")
            {
                return "S";
            }
            else if (direction == "S")
            {
                return "E";
            }
            else
            {
                return "N";
            }
        }
    }
}