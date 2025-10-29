using MazeAbstractFactory;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;

namespace Program
{
    class ProgramSingleton
    {
        static void Main(string[] args)
        {
            try
            {
                MazeGame game = new MazeGame();

                IMazeFactory mazeSingleton = MazeSingletonFactory.Instance();
                game.CreateMaze(mazeSingleton);

                IMazeFactory mazeSingletonTwo = MazeSingletonFactory.Instance();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
