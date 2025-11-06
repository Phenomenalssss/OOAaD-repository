using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyAdapter
{
    public class Turkey
    {
        public void SpecificName()
        {
            Console.WriteLine("Индюк");
        }

        public void SpecificVoice()
        {
            Console.WriteLine("гу-гу");
        }

        public void SpecificCanFly()
        {
            Console.WriteLine("Индюк не может летать");
        }
    }
}
