using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace MazeBuilder
{
    public class CountingMazeBuilder : IMazeBuilder
    {
        private int _rooms;
        private int _doors;

        public CountingMazeBuilder()
        {
            _rooms = _doors = 0;
        }

        public void BuildMaze() 
        {
            Console.WriteLine("----- Вы построили лабиринт-счётчик -----");
        }

        public Maze GetMaze() { return null; }

        public void BuildRoom(int n)
        {
            _rooms++;
        }

        public void BuildDoor(int n1, int n2)
        {
            _doors++;
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }
    }
}
