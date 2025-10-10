using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using MazeLibrary.Doors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _currentMaze;

        public StandardMazeBuilder()
        {
            _currentMaze = null;
        }

        public void BuildMaze()
        {
            Console.WriteLine("----- Вы построили лабиринт -----");
            _currentMaze = new Maze();
        }

        public Maze GetMaze()
        {
            return _currentMaze;
        }

        public void BuildRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Room room = new Room(n);
            _currentMaze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());

            Console.WriteLine($"Вы построили комнату №{n}");
        }

        public void BuildDoor(int n1, int n2)
        {
            Room r1 = _currentMaze.GetRoomByNumber(n1);
            Room r2 = _currentMaze.GetRoomByNumber(n2);
            Door d = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), d);
            r1.SetSide(CommonWall(r1, r2), d);

            Console.WriteLine($"Вы построили дверь между комнатам №{r1.Number} и №{r2.Number}");
        }

        public Direction CommonWall(Room r1, Room r2)
        {
            return Direction.North;
        }
    }
}
