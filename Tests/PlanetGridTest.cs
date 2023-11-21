using MarsRover.impl;

namespace Tests;

public class PlanetGridTest
{
    [Fact]
    public void GetRandomObstaclesPositions_NumberOfObstacles_ReturnsArrayOfObstacles()
    {
        var planetGrid = new PlanetGrid(1, 1, 3);

        var obstaclesPositions = planetGrid.GetObstaclesPositions();

        Assert.Equal(3, obstaclesPositions.Length);
    }
}