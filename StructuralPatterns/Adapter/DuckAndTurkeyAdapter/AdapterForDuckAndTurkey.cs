using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckAndTurkeyAdapter
{
    public class AdapterForDuckAndTurkey : IBird
    {
        private readonly Turkey _turkey;

        public AdapterForDuckAndTurkey(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Name()
        {
            _turkey.SpecificName();
        }

        public void Voice()
        {
            _turkey.SpecificVoice();
        }

        public void CanFly()
        {
            _turkey.SpecificCanFly();
        }
    }
}