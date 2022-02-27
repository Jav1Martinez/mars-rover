namespace MarsRover
{
    public interface IDirection
    {
        string InitialDirection();
        string RotateToLeft(string direction);
        string RotateToRight(string direction);
    }
}