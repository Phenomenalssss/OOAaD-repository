using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze(IMazeFactory factory)
        {
            Maze Maze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(9999);
            r1.Enter();
            Room r2 = factory.MakeRoom(1111);
            r2.Enter();
            Room r3 = factory.MakeRoom(5555);
            r3.Enter();
            Door theDoor = factory.MakeDoor(r1, r2);
            theDoor.Enter();

            Maze.AddRoom(r1);
            Maze.AddRoom(r2);

            Maze.GetRoomByNumber(r1.Number);

            Wall wall = factory.MakeWall();
            wall.Enter();

            r1.SetSide(Direction.North, factory.MakeWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, factory.MakeWall());
            r1.SetSide(Direction.West, factory.MakeWall());

            r2.SetSide(Direction.North, factory.MakeWall());
            r2.SetSide(Direction.East, factory.MakeWall());
            r2.SetSide(Direction.South, factory.MakeWall());
            r2.SetSide(Direction.West, theDoor);

            Console.WriteLine("----------");

            return Maze;
        }
    }
}
