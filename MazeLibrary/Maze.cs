using MazeLibrary.Rooms;
using System.ComponentModel.Design;

namespace MazeLibrary
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public Maze() { }

        public Maze(Maze otherMaze) 
        {
            _rooms = otherMaze._rooms;
        }

        public Maze Clone()
        {
            return new Maze(this);
        }

        public Room GetRoomByNumber(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            var room = _rooms.FirstOrDefault(r => r.Number == number) ?? throw new ArgumentException($"Комната №{number} не найдена");
            Console.WriteLine($"Комната под номером {number} найдена");
            return room;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
    }
}
