using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class Room : MapSite
    {
        public int roomNumber;
        private MapSite[] _sides = new MapSite[4];

        public Room(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                roomNumber = n;
            }
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату под номером {0}", roomNumber);
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
