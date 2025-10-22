using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    public class JustDirector : IMazeDirector
    {
        public void CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
        }
    }
}
