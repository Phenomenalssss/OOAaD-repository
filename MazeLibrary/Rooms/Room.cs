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

        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Number = number;
        }
        public int Number { get; private set; }

        public void Initialize(int number)
        {
            Console.WriteLine($"Вы изменили № комнаты ({Number} -> {number})");
            Number = number;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в обычную комнату под номером {0}", Number);
        }

        public MapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }
    }
}
