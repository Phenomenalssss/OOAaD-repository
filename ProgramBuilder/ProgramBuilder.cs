using MazeLibrary;
using MazeBuilder;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Program
{
    class ProgramBuilder
    {
        static void Main(string[] args)
        {
            try
            {
                Maze justMaze = new Maze();
                JustDirector justDirector = new JustDirector();
                JustMazeBuilder builder = new JustMazeBuilder();

                justDirector.CreateMaze(builder);
                justMaze = builder.GetMaze(); 

                Maze countingMaze = new Maze();
                int rooms, doors;
                CountingDirector countingDirector = new CountingDirector();
                CountingMazeBuilder countingBuilder = new CountingMazeBuilder();

                countingDirector.CreateMaze(countingBuilder);

                rooms = countingBuilder.GetCounts().rooms;
                doors = countingBuilder.GetCounts().doors;
                Console.WriteLine($"В лабиринте {rooms} комнат и {doors} дверей");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
        }
    }
}
