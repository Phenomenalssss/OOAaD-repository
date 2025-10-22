using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;

namespace MazePrototype
{
    public interface IPrototype
    {
        Maze MakeMaze();

        Room MakeRoom(int number);

        Wall MakeWall();

        Door MakeDoor(Room r1, Room r2);

        void Clone();
    }
}
