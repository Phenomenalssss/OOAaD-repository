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
    public class BombedMazeGame : MazeGame
    {
        public override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }
        
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int n)
        {
            Console.WriteLine($"Вы создали комнату №{n} с бомбой");
            return new RoomWithBomb(n);
        }
    }
}
