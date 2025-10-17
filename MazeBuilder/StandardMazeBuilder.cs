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

        public void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Room room = new Room(number);
            _currentMaze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());

            Console.WriteLine($"Вы построили комнату №{number}");
        }

        public void BuildDoor(int number1, int number2)
        {
            Room room1 = _currentMaze.GetRoomByNumber(number1);
            Room room2 = _currentMaze.GetRoomByNumber(number2);
            Door door = new Door(room1, room2);

            room1.SetSide(CommonWall(room1, room2), door);
            room1.SetSide(CommonWall(room1, room2), door);

            Console.WriteLine($"Вы построили дверь между комнатам №{room1.Number} и №{room2.Number}");
        }

        public Direction CommonWall(Room room1, Room room2)
        {
            return Direction.North;
        }
    }
}
