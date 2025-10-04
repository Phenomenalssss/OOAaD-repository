using MazeLibrary.Rooms;

namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }

        public Room RoomNumber(int n)
        {
            return new Room(n);
        }

        public List<Room> rooms = new List<Room>();
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
    }
}
