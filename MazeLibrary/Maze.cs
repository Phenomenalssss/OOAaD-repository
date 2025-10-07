using MazeLibrary.Rooms;
using System.ComponentModel.Design;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }

        public Room RoomNumber(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            else
            {
                foreach(var room in rooms)
                {
                    if (room.roomNumber == n)
                    {
                        Console.WriteLine("Комната под номером {0} найдена", n);
                        return room;
                    }
                }
                throw new ArgumentException($"Комната под номером {n} не найдена");
            }
        }

        public List<Room> rooms = new List<Room>();
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
    }
}
