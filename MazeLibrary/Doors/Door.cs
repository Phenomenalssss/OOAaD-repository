using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        private Room room1;
        private Room room2;
        private bool isOpen;
        public Door(Room r1, Room r2)
        {
            room1 = r1;
            room2 = r2;
            isOpen = true;
        }

        public virtual void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Вы прошли через дверь между {0} и {1} комнатами", room1.roomNumber, room2.roomNumber);
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == room1) return room2;
            if (room == room2) return room1;
            return null;
        }
    }
}
