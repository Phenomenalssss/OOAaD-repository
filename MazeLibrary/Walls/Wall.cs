using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class Wall : MapSite
    {
        public Wall() { }

        public virtual void Enter() 
        {
            Console.WriteLine("Вы упёрлись в стену");
        }
    }
}
