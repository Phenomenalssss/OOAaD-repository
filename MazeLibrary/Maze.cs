using MazeLibrary.Rooms;
using System.ComponentModel.Design;

namespace MazeLibrary
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public Maze() { }

        public Room GetRoomByNumber(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            var room = _rooms.FirstOrDefault(r => r.Number == n) ?? throw new ArgumentException($"Комната №{n} не найдена");
            Console.WriteLine($"Комната под номером {n} найдена");
            return room;
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
    }
}
