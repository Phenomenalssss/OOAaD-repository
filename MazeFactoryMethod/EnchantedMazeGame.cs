using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали магический лабиринт -----");
            return new Maze();
        }

        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Вы создали магическую комнату №{number}");
            return new EnchantedRoom(number);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            Console.WriteLine($"Вы создали магическую дверь между комнатами №{room1.Number} и №{room2.Number}");
            return new EnchantedDoor(room1, room2);
        }
    }
}
