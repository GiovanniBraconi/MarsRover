namespace MarsRover.impl;

class Program
{
    private static MarsRover _rover = null!;

    static void Main()
    {
        //write what each command does
        Console.WriteLine("f: move forward");
        Console.WriteLine("b: move backward");
        Console.WriteLine("l: turn left");
        Console.WriteLine("r: turn right");
        Console.WriteLine("Rover starting position: (0, 0)");
        _rover = new MarsRover(new[] {0, 0}, 'N', new PlanetGrid(1, 1, 3));
        Console.WriteLine("Enter a command sequence:");
        string? commandSequence = Console.ReadLine();
        char[]? commands = commandSequence?.ToCharArray();
        if (commands != null)
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'f':
                        _rover.MoveForward();
                        break;
                    case 'b':
                        _rover.MoveBackward();
                        break;
                    case 'l':
                        _rover.TurnLeft();
                        break;
                    case 'r':
                        _rover.TurnRight();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

        Console.WriteLine("Press a key to exit.");
        Console.ReadKey(true);
    }
}