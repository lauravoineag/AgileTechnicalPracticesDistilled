namespace SimpleMarsRover;

public class MarsRover
{
    private int _xPosition = 0;
    private int _yPosition = 0;
    private string _direction ="N";
    private int _gridSize;

    public MarsRover(int gridSize)
    {
        _gridSize = gridSize;
    }
    public string Execute(string command)
    {
        if (command == "M")
        {
            _yPosition += 1;
        }
        else
        {
            _yPosition += 2;}
        return $"{_xPosition}:{_yPosition}:{_direction}";
    }

    
}