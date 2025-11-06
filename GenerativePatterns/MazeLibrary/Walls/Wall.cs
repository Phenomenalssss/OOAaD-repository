using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class Wall : IMapSite
    {
        public Wall() { }

        public Wall(Wall otherWall) { }

        public virtual IMapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную стену");
            return new Wall(this);
        }

        public void Enter() 
        {
            Console.WriteLine("Вы упёрлись в стену");
        }
    }
}
