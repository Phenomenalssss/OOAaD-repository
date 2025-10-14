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

        public override Room MakeRoom(int n)
        {
            Console.WriteLine($"Вы создали магическую комнату №{n}");
            return new EnchantedRoom(n);
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            Console.WriteLine($"Вы создали магическую дверь между комнатами №{r1.Number} и №{r2.Number}");
            return new EnchantedDoor(r1, r2);
        }
    }
}
