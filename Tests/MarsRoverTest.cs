using MarsRover.impl;

namespace Tests;

public class MarsRoverTest
{
    [Theory]
    [InlineData('N', new[] {0, 1})]
    [InlineData('S', new[] {0, -1})]
    [InlineData('E', new[] {1, 0})]
    [InlineData('W', new[] {-1, 0})]
    public void MoveForward_Direction_MovesTheRoverBasedOnDirection(char direction, int[] expected)
    {
        var rover = new MarsRover.impl.MarsRover(new[] {0, 0}, direction, new PlanetGrid(1, 1, 0));

        rover.MoveForward();

        Assert.Equal(expected, rover.GetPosition());
    }

    [Theory]
    [InlineData('N', new[] {0, -1})]
    [InlineData('S', new[] {0, 1})]
    [InlineData('E', new[] {-1, 0})]
    [InlineData('W', new[] {1, 0})]
    public void MoveBackward_Direction_MovesTheRoverBasedOnDirection(char direction, int[] expected)
    {
        var rover = new MarsRover.impl.MarsRover(new[] {0, 0}, direction, new PlanetGrid(1, 1, 0));

        rover.MoveBackward();

        Assert.Equal(expected, rover.GetPosition());
    }

    [Theory]
    [InlineData('N', 'W')]
    [InlineData('S', 'E')]
    [InlineData('E', 'N')]
    [InlineData('W', 'S')]
    public void TurnLeft_Direction_TurnsTheRoverBasedOnDirection(char direction, char expected)
    {
        var rover = new MarsRover.impl.MarsRover(new[] {0, 0}, direction, new PlanetGrid(1, 1, 0));

        rover.TurnLeft();

        Assert.Equal(expected, rover.GetDirection());
    }

    [Theory]
    [InlineData('N', 'E')]
    [InlineData('S', 'W')]
    [InlineData('E', 'S')]
    [InlineData('W', 'N')]
    public void TurnRight_Direction_TurnsTheRoverBasedOnDirection(char direction, char expected)
    {
        var rover = new MarsRover.impl.MarsRover(new[] {0, 0}, direction, new PlanetGrid(1, 1, 0));

        rover.TurnRight();

        Assert.Equal(expected, rover.GetDirection());
    }


    [Theory]
    [InlineData('N', new[] {0, 1}, new[] {0, -1})]
    [InlineData('S', new[] {0, -1}, new[] {0, 1})]
    [InlineData('E', new[] {1, 0}, new[] {-1, 0})]
    [InlineData('W', new[] {-1, 0}, new[] {1, 0})]
    public void MoveForward_RoverPositionedOnEdgeFacingIt_MovesTheRoverOnTheOppositeEdge(char direction,
        int[] currentPosition, int[] expected)
    {
        var rover = new MarsRover.impl.MarsRover(currentPosition, direction, new PlanetGrid(1, 1, 0));

        rover.MoveForward();

        Assert.Equal(expected, rover.GetPosition());
    }

    [Theory]
    [InlineData('N', new[] {0, -1}, new[] {0, 1})]
    [InlineData('S', new[] {0, 1}, new[] {0, -1})]
    [InlineData('E', new[] {-1, 0}, new[] {1, 0})]
    [InlineData('W', new[] {1, 0}, new[] {-1, 0})]
    public void MoveBackward_RoverPositionedOnEdgeFacingTheOppositeEdge_MovesTheRoverOnTheOppositeEdge(char direction,
        int[] currentPosition, int[] expected)
    {
        var rover = new MarsRover.impl.MarsRover(currentPosition, direction, new PlanetGrid(1, 1, 0));

        rover.MoveBackward();

        Assert.Equal(expected, rover.GetPosition());
    }
}