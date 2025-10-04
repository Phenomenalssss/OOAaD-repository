using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAbstractFactory
{
    public class BombedMazeFactory : MazeFactory
    {
        public BombedMazeFactory() { }

        public override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }

        public override BombedWall MakeWall()
        {
            return new BombedWall();
        }

        public override RoomWithABomb MakeRoom(int n)
        {
            return new RoomWithABomb(n);
        }
    }
}
