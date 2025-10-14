using MazeLibrary;
using MazeAbstractFactory;
using MazeLibrary.Walls;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;

namespace MazePrototype
{
    public class MazePrototypeFactory : JustMazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory(Maze maze, Wall wall, Room room, Door door)
        {
            _prototypeDoor = door;
            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
        }

        public virtual Wall MakeWall()
        {
            return _prototypeWall.Clone();
        }

        public virtual Door MakeDoor(Room r1, Room r2)
        {
            Door door = _prototypeDoor.Clone();
            door.Initialize(r1, r2);
            return door;
        }
    }
}
