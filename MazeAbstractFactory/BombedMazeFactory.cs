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
    public class BombedMazeFactory : IMazeFactory
    {
        public BombedMazeFactory() { }

        public Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }

        public Wall MakeWall()
        {
            return new BombedWall();
        }

        public Room MakeRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new RoomWithBomb(number);
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
