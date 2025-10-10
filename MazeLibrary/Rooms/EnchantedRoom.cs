using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom : Room
    {
        private readonly Spell _spell;

        public EnchantedRoom(int n) : base(n) 
        {
            _spell = new Spell("Levitation");
        }

        public void CastSpell()
        {
            Console.WriteLine("Вы использовали заклинание");
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в магическую комнату под номером {Number} с заклинанием {_spell.Name}");
        }
    }
}
