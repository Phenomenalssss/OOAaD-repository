using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom : Room
    {
        int roomNumber;
        Spell _spell;
        private MapSite[] sides = new MapSite[4];
        public EnchantedRoom(int n, Spell spell) : base(n)
        {
            roomNumber = n;
            _spell = spell;  
        }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в магическую комнату под номером {0}", roomNumber);
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
