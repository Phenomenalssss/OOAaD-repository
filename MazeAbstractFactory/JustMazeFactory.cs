using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;

namespace MazeAbstractFactory
{
    public class JustMazeFactory : IMazeFactory
    {
        public Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали обычный лабиринт -----");
            return new Maze();
        }

        public Wall MakeWall()
        {
            return new Wall();
        }

        public Room MakeRoom(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new Room(n);
        }

        public Door MakeDoor(Room r1, Room r2)
        {
            return new Door(r1, r2);
        }
    }
}
