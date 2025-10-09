using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        private int _roomNumber;
        private MapSite[] _sides = new MapSite[4];

        public RoomWithBomb(int n) : base(n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                _roomNumber = n;
            }
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой под номером {0}", _roomNumber);
        }
    }
}
