namespace MarsRover
{
    public interface ICoordinate
    {
        int GetX();
        int GetY();

        void Move(string direction);
    }
}