using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;
using MazeLibrary.Walls;

namespace MazeLibrary.Rooms
{
    public class Room : IMapSite
    {
        private IMapSite[] _sides = new IMapSite[4];

        public Room(Room r1)
        {
            Number = r1.Number;
            _sides = new IMapSite[4];
            for (int i = 0; i < 4; i++)
            {
                _sides[i] = r1._sides[i].Clone();
            }
        }

        public Room(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Number = number;
            SetSide(Direction.North, new Wall());
            SetSide(Direction.South, new Wall());
            SetSide(Direction.East, new Wall());
            SetSide(Direction.West, new Wall());
        }
        public int Number { get; private set; }

        public virtual IMapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную комнату");
            return new Room(this);
        }

        public void Initialize(int number)
        {
            Console.WriteLine($"Вы изменили № комнаты на {number}");
            Number = number;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в обычную комнату под номером {0}", Number);
        }

        public IMapSite GetSide(Direction direction)
        {
            return _sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite IMapSite)
        {
            _sides[(int)direction] = IMapSite;
        }
    }
}
