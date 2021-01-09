using System;
using System.Collections.Generic;

namespace Mars_Rover
{
    public class MarsRoverOperation
    {
        public enum TurnAction
        {
            Right = 'R',
            Left = 'L'
        }
        public enum Direction
        {
            East = 'E',
            West = 'W',
            North = 'N',
            South = 'S'
        }

        public static Tuple<int, int, char> GetLastCooardinate(char[] roverPosition, char[] moveAction)
        {
            int x = int.Parse(roverPosition[0].ToString());
            int y = int.Parse(roverPosition[1].ToString());
            Direction direction = (Direction)roverPosition[2];
            foreach (char act in moveAction)
            {
                if(!string.IsNullOrEmpty(Enum.GetName(typeof(TurnAction), act)))
                {
                    direction = GetDirection(direction, (TurnAction)act);
                    continue;
                }
                ChangeCoordinates(ref x, ref y, direction);
            }
            return Tuple.Create(x, y, (char)direction);
        }

        public static void ChangeCoordinates(ref int x, ref int y, Direction direction)
        {
            if (direction == Direction.East)
            {
                x += 1;
            }
            else if (direction == Direction.West)
            {
                x -= 1;
            }
            else if (direction == Direction.North)
            {
                y += 1;
            }
            else 
            {
                y -= 1;
            }
        }

        public static Direction GetDirection(Direction currentDirection, TurnAction moveAction)
        {
            Direction newRoute;
            if (currentDirection == Direction.North)
            {
                if (moveAction == TurnAction.Right)
                {
                    newRoute = Direction.East;
                }
                else
                {
                    newRoute = Direction.West;
                }
            } 
            else if (currentDirection == Direction.South)
            {
                if (moveAction == TurnAction.Right)
                {
                    newRoute = Direction.West;
                }
                else
                {
                    newRoute = Direction.East;
                }
            }
            else if (currentDirection == Direction.East)
            {
                if (moveAction == TurnAction.Right)
                {
                    newRoute = Direction.South;
                }
                else
                {
                    newRoute = Direction.North;
                }
            }
            else // currentState == "W"
            {
                if (moveAction == TurnAction.Right)
                {
                    newRoute = Direction.North;
                }
                else
                {
                    newRoute = Direction.South;
                }
            }
            return newRoute;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter upper right coordinates of the plateu:");
            string[] plateuUpperRight = Console.ReadLine().Split(' ');
            ValidatePlateuUpperRightCoordinates(plateuUpperRight);
            char[] roverPosition;
            char[] moveAction;
            List<Tuple<int, int, char>> lastCoordinates = new List<Tuple<int, int, char>>();
            while (true)
            {
                Console.WriteLine("Enter rover's position:");
                roverPosition = Array.ConvertAll(Console.ReadLine().Split(' '), s=> char.Parse(s));
                ValidateRoverPosition(roverPosition);
                Console.WriteLine("Enter rover's move actions:");
                moveAction = Console.ReadLine().ToCharArray();
                ValidateMoveActions(moveAction);
                lastCoordinates.Add(GetLastCooardinate(roverPosition, moveAction));
                Console.WriteLine("If you want to see result press F:");
                if (Console.ReadLine() == "F")
                {
                    break;
                }
            }
            PrintResults(lastCoordinates);
            Console.ReadKey();
        }

        public static void PrintResults(List<Tuple<int, int, char>> lastCoordinates)
        {
            foreach (var result in lastCoordinates)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", result.Item1, result.Item2, result.Item3));
            }
        }

        public static void ValidateMoveActions(char[] moveAction)
        {
            foreach (var action in moveAction)
            {
                TurnAction act = (TurnAction)action;
                if (act != TurnAction.Left && act != TurnAction.Right && action != 'M')
                {
                    throw new FormatException("Incorrect input for actions. Input can only includes L,R,M characters.");
                }
            }
        }

        public static void ValidatePlateuUpperRightCoordinates(string[] plateuUpperRight)
        {
            if (plateuUpperRight == null || plateuUpperRight.Length != 2)
            {
                throw new FormatException("Plateu upper-rigth coordinates must be 2 integer values. (x,y)");
            }
            foreach (var coord in plateuUpperRight)
            {
                if (!int.TryParse(coord, out int itemInt))
                {
                    throw new FormatException("Coordinate must be integer.");
                }
            }
        }

        public static void ValidateRoverPosition(char[] roverPosition)
        {
            if (roverPosition == null || roverPosition.Length != 3)
            {
                throw new FormatException("Rover's position includes x,y coordinates and route. Etc. 1 2 N");
            }
            if (!int.TryParse(roverPosition[0].ToString(), out _) || !int.TryParse(roverPosition[1].ToString(), out _))
            {
                throw new FormatException("First and second position must be integer.");
            }
            if (string.IsNullOrEmpty(Enum.GetName(typeof(Direction), roverPosition[2])))
            {
                throw new FormatException("Last parameter must be direction(N, S, E ,W).");
            }
        }
    }
}
