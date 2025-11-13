using DuckAndTurkeyAdapter;
using System.Buffers;
using System.Threading.Channels;

namespace Program
{
    class ProgramFacade
    {
        static void Main(string[] args)
        {
            IDuck duck = new Duck();
            duck.Name();
            duck.Voice();
            duck.CanFly();

            IDuck turkey = new AdapterForDuckAndTurkey(new Turkey());
            turkey.Name();
            turkey.Voice();
            turkey.CanFly();
        }
    }
}
