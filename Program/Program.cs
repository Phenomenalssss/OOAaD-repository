using MazeAbstractFactory;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGameFactory game = new MazeGameFactory();

            MazeFactory justfactory = new MazeFactory();
            game.CreateMaze(justfactory);

            EnchantedMazeFactory enchantedfactory = new EnchantedMazeFactory();
            game.CreateMaze(enchantedfactory);

            BombedMazeFactory bombedfactory = new BombedMazeFactory();
            game.CreateMaze(bombedfactory);
        }
    }
}
