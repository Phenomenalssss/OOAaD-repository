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
    public interface IMazeFactory
    {
        Maze MakeMaze();

        Wall MakeWall();

        Room MakeRoom(int n);

        Door MakeDoor(Room r1, Room r2);
    }
}
