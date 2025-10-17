using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class BombedWall : Wall
    {
        private bool _bomb;

        public BombedWall() 
        {
            _bomb = true;
        }

        public BombedWall(BombedWall otherBombedWall)
        {
            _bomb = otherBombedWall._bomb;
        }

        public override Wall Clone()
        {
            Console.WriteLine("Вы клонировали стену с бомбой");
            return new BombedWall(this);
        }

        public bool HasBomb()
        {
            return _bomb;
        }

        public void Enter()
        {
            Console.WriteLine("Вы упёрлись в стену с бомбой");
        }
    }
}
