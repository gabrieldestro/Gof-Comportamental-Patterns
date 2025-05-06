using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public interface IAbstractCollection
    {
        ConcreteIterator CreateIterator();
    }
}
