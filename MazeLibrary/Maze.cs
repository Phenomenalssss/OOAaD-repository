using MazeLibrary.Rooms;
using System.ComponentModel.Design;

namespace MazeLibrary
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public Maze() { }

        public Room RoomNumber(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                var room = _rooms.FirstOrDefault(r => r.RoomNumber == n);
                if (room != null)
                {
                    Console.WriteLine($"Комната под номером {n} найдена");
                    return room;
                }
                else
                {
                    throw new ArgumentException($"Комната под номером {n} не найдена");
                }
            }
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
    }
}
