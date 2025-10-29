using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int number) : base(number) 
        {
            _spell = new Spell("Levitation");
        }

        public EnchantedRoom(EnchantedRoom otherRoom) : base(otherRoom)
        {
            _spell = otherRoom._spell;
        }

        public void Initialize(Spell spell)
        {
            _spell = spell;
        }

        public override Room Clone()
        {
            Console.WriteLine("Вы клонировали магическую комнату");
            return new EnchantedRoom(this);
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
