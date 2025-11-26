using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace IteratorAggregates
{
    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
