namespace MarsRover.impl;

public class MarsRover
{
    private int _xCoordinate;
    private int _yCoordinate;
    private char _direction;
    private PlanetGrid _planetGrid;

    public MarsRover(int[] startingPosition, char direction, PlanetGrid planetGrid)
    {
        _xCoordinate = startingPosition[0];
        _yCoordinate = startingPosition[1];
        _direction = direction;
        _planetGrid = planetGrid;
    }

    public int[] GetPosition()
    {
        return new[] {_xCoordinate, _yCoordinate};
    }

    public char GetDirection()
    {
        return _direction;
    }

    public void MoveForward()
    {
        int nextXCoordinate = _xCoordinate;
        int nextYCoordinate = _yCoordinate;
        switch (_direction)
        {
            case 'N':
                if (_yCoordinate == _planetGrid.GetMaxGridY())
                {
                    nextYCoordinate = -_yCoordinate;
                }
                else
                {
                    nextYCoordinate++;
                }

                break;
            case 'S':
                if (_yCoordinate == -_planetGrid.GetMaxGridY())
                {
                    nextYCoordinate = -_yCoordinate;
                }
                else
                {
                    nextYCoordinate--;
                }

                break;
            case 'E':
                if (_xCoordinate == _planetGrid.GetMaxGridX())
                {
                    nextXCoordinate = -_xCoordinate;
                }
                else
                {
                    nextXCoordinate++;
                }

                break;
            case 'W':
                if (_xCoordinate == -_planetGrid.GetMaxGridX())
                {
                    nextXCoordinate = -_xCoordinate;
                }
                else
                {
                    nextXCoordinate--;
                }

                break;
        }


        if (IsObstacleInNextPosition(nextXCoordinate, nextYCoordinate))
        {
            Console.WriteLine("Obstacle detected at: (" + nextXCoordinate + ", " + nextYCoordinate + ")");
            Console.WriteLine("Press a key to exit.");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        _xCoordinate = nextXCoordinate;
        _yCoordinate = nextYCoordinate;


        Console.WriteLine("Rover position: (" + _xCoordinate + ", " + _yCoordinate + ")");
    }

    public void MoveBackward()
    {
        int nextXCoordinate = _xCoordinate;
        int nextYCoordinate = _yCoordinate;
        switch (_direction)
        {
            case 'N':
                if (_yCoordinate == -_planetGrid.GetMaxGridY())
                {
                    nextYCoordinate = -_yCoordinate;
                }
                else
                {
                    nextYCoordinate--;
                }

                break;
            case 'S':
                if (_yCoordinate == _planetGrid.GetMaxGridY())
                {
                    nextYCoordinate = -_yCoordinate;
                }
                else
                {
                    nextYCoordinate++;
                }

                break;
            case 'E':
                if (_xCoordinate == -_planetGrid.GetMaxGridX())
                {
                    nextXCoordinate = -_xCoordinate;
                }
                else
                {
                    nextXCoordinate--;
                }

                break;
            case 'W':
                if (_xCoordinate == _planetGrid.GetMaxGridX())
                {
                    nextXCoordinate = -_xCoordinate;
                }
                else
                {
                    nextXCoordinate++;
                }

                break;
        }


        if (IsObstacleInNextPosition(nextXCoordinate, nextYCoordinate))
        {
            Console.WriteLine("Obstacle detected at: (" + nextXCoordinate + ", " + nextYCoordinate + ")");
            Console.WriteLine("Press a key to exit.");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        _xCoordinate = nextXCoordinate;
        _yCoordinate = nextYCoordinate;

        Console.WriteLine("Rover position: (" + _xCoordinate + ", " + _yCoordinate + ")");
    }

    private bool IsObstacleInNextPosition(int nextXCoordinate, int nextYCoordinate)
    {
        var obstaclesPositions = _planetGrid.GetObstaclesPositions();
        foreach (var obstaclePosition in obstaclesPositions)
        {
            if (obstaclePosition.SequenceEqual(new[] {nextXCoordinate, nextYCoordinate}))
            {
                return true;
            }
        }

        return false;
    }


    public void TurnLeft()
    {
        switch (_direction)
        {
            case 'N':
                _direction = 'W';
                break;
            case 'S':
                _direction = 'E';
                break;
            case 'E':
                _direction = 'N';
                break;
            case 'W':
                _direction = 'S';
                break;
        }

        Console.WriteLine("Rover direction: " + _direction);
    }

    public void TurnRight()
    {
        switch (_direction)
        {
            case 'N':
                _direction = 'E';
                break;
            case 'S':
                _direction = 'W';
                break;
            case 'E':
                _direction = 'S';
                break;
            case 'W':
                _direction = 'N';
                break;
        }

        Console.WriteLine("Rover direction: " + _direction);
    }
}