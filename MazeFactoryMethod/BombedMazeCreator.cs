using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFactoryMethod
{
    public class BombedMazeCreator : MazeCreator
    {
        protected override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }

        protected override Wall MakeWall()
        {
            return new BombedWall();
        }

        protected override Room MakeRoom(int number)
        {
            Console.WriteLine($"Вы создали комнату №{number} с бомбой");
            return new RoomWithBomb(number);
        }
    }
}
