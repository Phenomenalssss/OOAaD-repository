using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithABomb : Room
    {
        public int roomNumber;
        private MapSite[] _sides = new MapSite[4];

        public RoomWithABomb(int n) : base(n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            roomNumber = n;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой под номером {0}", roomNumber);
        }
        public MapSite GetSide(Direction dir)
        {
            return _sides[(int)dir];
        }
        
        public void SetSide(Direction dir, MapSite mapsite)
        {
            _sides[(int)dir] = mapsite;
        }
    }
}
