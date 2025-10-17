using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;
        protected bool IsOpen { get; private set; }

        public Door() { }

        public Door(Door otherDoor) 
        {
            _room1 = otherDoor._room1;
            _room2 = otherDoor._room2;
        }

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
            IsOpen = true;
        }

        public void Initialize(Room room1, Room room2)
        {
            Console.WriteLine($"Вы изменили комнаты, между которыми находится дверь (№{_room1.Number} -> №{room1.Number}, №{_room2.Number} -> №{room2.Number})");
            _room1 = room1;
            _room2 = room2;
        }

        protected virtual void EnterIsOpen(Room room1, Room room2) 
        {
            Console.WriteLine("Вы прошли через дверь между {0} и {1} комнатами", _room1.Number, _room2.Number);
        }

        public virtual Door Clone()
        {
            Console.WriteLine("Вы клонировали обычную дверь");
            return new Door(this);
        }

        public void Enter()
        {
            if (IsOpen)
            {
                EnterIsOpen(_room1, _room2);
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
            {
                return _room2;
            }
            if (room == _room2)
            {
                return _room1;
            }
            throw new Exception("Данной комнаты не существует");
        }
    }
}
