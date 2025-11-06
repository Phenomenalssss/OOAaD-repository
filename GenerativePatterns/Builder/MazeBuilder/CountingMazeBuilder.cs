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

        public void BuildMaze() { }

        public void BuildRoom(int number)
        {
            _rooms++;
        }

        public void BuildDoor(int number1, int number2)
        {
            _doors++;
        }

        public (int rooms, int doors) GetCounts()
        {
            return (_rooms, _doors);
        }
    }
}
