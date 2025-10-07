using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class EnchantedDoor : Door
    {
        private Room _room1;
        private Room _room2;
        private bool _isOpen;

        public EnchantedDoor(Room r1, Room r2) : base(r1, r2)
        {
            _room1 = r1;
            _room2 = r2;
            _isOpen = true;
        }

        public override void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Вы прошли через магическую дверь между {0} и {1} комнатами", _room1.roomNumber, _room2.roomNumber);
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
    }
}
