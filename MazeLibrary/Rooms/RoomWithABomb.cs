using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithABomb : Room
    {
        int roomNumber;
        private MapSite[] sides = new MapSite[4];
        public RoomWithABomb(int n) : base(n)
        {
            roomNumber = n;
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой под номером {0}", roomNumber);
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
