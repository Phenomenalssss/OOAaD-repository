using MazeLibrary;
using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAbstractFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory() { }

        public override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали магический лабиринт -----");
            return new Maze();
        }

        public override EnchantedRoom MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public override DoorNeedingSpell MakeDoor(Room r1, Room r2)
        {
            return new DoorNeedingSpell(r1, r2);
        }

        protected Spell CastSpell() 
        {
            Console.WriteLine("Вы использовали заклинание");
            return new Spell();
        }
    }
}
