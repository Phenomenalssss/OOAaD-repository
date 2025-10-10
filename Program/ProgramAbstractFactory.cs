using MazeAbstractFactory;
using MazeLibrary;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ProgramAbstractFactory
    {
        static void Main(string[] args)
        {
            try
            {
                MazeGame game = new MazeGame();

                JustMazeFactory justfactory = new JustMazeFactory();
                game.CreateMaze(justfactory);

                EnchantedMazeFactory enchantedfactory = new EnchantedMazeFactory();
                game.CreateMaze(enchantedfactory);

                var room = new EnchantedRoom(3);
                room.Enter();
                room.CastSpell();

                BombedMazeFactory bombedfactory = new BombedMazeFactory();
                game.CreateMaze(bombedfactory);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
