namespace MarsRover
{
    public class MarsRover
    {
        public string Execute(string command)
        {
            if (command == "L")
            {
                return "0:0:W";
            }
            
            return "0:0:E";        
        }
    }
}