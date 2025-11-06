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
    public class EnchantedMazeFactory : IMazeFactory
    {
        public EnchantedMazeFactory() { }

        public Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали магический лабиринт -----");
            return new Maze();
        }

        public Room MakeRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            return new EnchantedRoom(number);
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        public Wall MakeWall()
        {
            return new Wall();
        }
    }
}
