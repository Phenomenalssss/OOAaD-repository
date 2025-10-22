using MazeLibrary;
using MazeAbstractFactory;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;

namespace MazePrototype
{
    public class JustMazePrototype : IPrototype
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public JustMazePrototype(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public void Clone()
        {

        }

        public Maze MakeMaze()
        {
            return _prototypeMaze.Clone();
        }

        public Room MakeRoom(int number) 
        {
            _prototypeRoom.Initialize(number);
            return _prototypeRoom;
        }

        public Wall MakeWall()
        {
            return _prototypeWall.Clone();
        }

        public Door MakeDoor(Room room1, Room room2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}
