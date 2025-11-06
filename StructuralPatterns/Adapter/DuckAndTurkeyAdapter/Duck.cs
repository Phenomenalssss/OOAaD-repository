namespace DuckAndTurkeyAdapter
{
    public class Duck : IBird
    {
        public void Name()
        {
            Console.WriteLine("Утка");
        }

        public void Voice()
        {
            Console.WriteLine("кря-кря");
        }

        public void CanFly()
        {
            Console.WriteLine("Утка может летать");
        }
    }
}