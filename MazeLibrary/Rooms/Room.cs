using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class Room : MapSite
    {
        private MapSite[] _sides = new MapSite[4];

        public Room(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Number = n;
        }
        public int Number { get; private init; }


        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату под номером {0}", Number);
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
