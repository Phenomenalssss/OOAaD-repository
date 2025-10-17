using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number) { }

        public override void Enter()
        {
            Console.WriteLine("Вы вошли в комнату с бомбой под номером {0}", Number);
        }
    }
}
