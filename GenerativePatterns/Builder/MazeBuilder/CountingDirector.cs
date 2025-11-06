using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilder
{
    public class CountingDirector : IMazeDirector
    {
        public void CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();

            int n = 1;
            for (int i = 1; i <= 1000; i++)
            {
                builder.BuildRoom(i);
                if (i % 3 == 0)
                {
                    builder.BuildDoor(n, n + 1);
                    n += 2;
                }
            }
        }
    }
}
