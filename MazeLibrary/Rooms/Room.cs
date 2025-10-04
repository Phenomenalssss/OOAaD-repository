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
        private MapSite[] sides = new MapSite[4];
        public Room(int n)
        {
            roomNumber = n;
        }

        public virtual void Enter()
        {
            Console.WriteLine("Вы вошли в комнату под номером {0}", roomNumber);
        }
        public MapSite GetSide(Direction dir)
        {
            return sides[(int)dir];
        }

        public void SetSide(Direction dir, MapSite mapsite)
        {
            sides[(int)dir] = mapsite;
        }
    }
}
