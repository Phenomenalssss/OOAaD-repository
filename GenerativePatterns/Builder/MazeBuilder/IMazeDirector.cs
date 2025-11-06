using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace MazeBuilder
{
    public interface IMazeDirector
    {
        void CreateMaze(IMazeBuilder builder);
    }
}
