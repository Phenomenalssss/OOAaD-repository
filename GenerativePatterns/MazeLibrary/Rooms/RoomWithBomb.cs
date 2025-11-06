using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        private bool _bomb;

        public RoomWithBomb(int number) : base(number)
        {
            _bomb = true;
        }

        public RoomWithBomb(RoomWithBomb otherRoom) : base(otherRoom)
        {
            _bomb = otherRoom._bomb;
        }

        public override Room Clone()
        {
            Console.WriteLine("Вы клонировали комнату с бомбой");
            return new RoomWithBomb(this);
        }

        public bool HasBomb()
        {
            return _bomb;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой под номером {0}", Number);
        }
    }
}
