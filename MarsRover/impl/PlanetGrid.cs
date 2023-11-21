namespace MarsRover.impl;

public class PlanetGrid
{
    private int _maxGridX;
    private int _maxGridY;
    private int _numberOfObstacles;
    private int[][] _obstaclesPositions;

    public PlanetGrid(int maxGridX, int maxGridY, int numberOfObstacles)
    {
        _maxGridX = maxGridX;
        _maxGridY = maxGridY;
        _numberOfObstacles = numberOfObstacles;
        _obstaclesPositions = GetRandomObstaclesPositions();
    }

    private int[][] GetRandomObstaclesPositions()
    {
        Random random = new Random();
        Console.WriteLine($"Number of obstacles: {_numberOfObstacles}");
        int[][] obstaclesPositions = new int[_numberOfObstacles][];
        int i = 0;
        while (i < _numberOfObstacles)
        {
            int obstaclePositionX = random.Next(-_maxGridX, _maxGridX + 1);
            int obstaclePositionY = random.Next(-_maxGridY, _maxGridY + 1);
            int[] obstaclePosition = new int[] {obstaclePositionX, obstaclePositionY};
            if (!obstaclePosition.SequenceEqual(new[] {0, 0}) &&
                !IsPositionOccupied(obstaclePosition, obstaclesPositions))
            {
                obstaclesPositions[i] = obstaclePosition;
                obstaclesPositions[i][0] = obstaclePositionX;
                obstaclesPositions[i][1] = obstaclePositionY;
                Console.WriteLine($"Obstacle {i + 1} position: ({obstaclesPositions[i][0]}, {obstaclesPositions[i][1]})");
                i++;
            }
        }


        return obstaclesPositions;
    }

    private bool IsPositionOccupied(int[] position, int[][] obstaclesPositions)
    {
        foreach (var obstaclePosition in obstaclesPositions)
        {
            if (obstaclePosition is not null)
            {
                if (obstaclePosition.SequenceEqual(position))
                {
                    return true;
                }
            }
        }

        return false;
    }

    public int[][] GetObstaclesPositions()
    {
        return _obstaclesPositions;
    }

    public int GetMaxGridX()
    {
        return _maxGridX;
    }

    public int GetMaxGridY()
    {
        return _maxGridY;
    }
}