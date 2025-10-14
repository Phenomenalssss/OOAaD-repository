using MazeLibrary;
using MazeBuilder;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ProgramBuilder
    {
        static void Main(string[] args)
        {
            try
            {
                Maze maze = new Maze();
                MazeBuilder.MazeGame game = new MazeBuilder.MazeGame();
                StandardMazeBuilder builder = new StandardMazeBuilder();

                game.CreateMaze(builder);
                maze = builder.GetMaze();

                int rooms, doors;
                CountingMazeBuilder countingbuilder = new CountingMazeBuilder();
                game.CreateComplexMaze(countingbuilder);
                countingbuilder.GetCounts(out rooms, out doors);
                Console.WriteLine($"В лабиринте {rooms} комнат и {doors} дверей");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
