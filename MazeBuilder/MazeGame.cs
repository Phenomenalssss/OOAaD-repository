using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace MazeBuilder
{
    public class MazeGame
    {
        public MazeGame() { }

        public Maze CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        public Maze CreateComplexMaze(IMazeBuilder builder)
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

            return builder.GetMaze();
        }
    }
}
