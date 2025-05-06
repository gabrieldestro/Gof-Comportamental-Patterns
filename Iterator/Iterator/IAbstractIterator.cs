using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public interface IAbstractIterator
    {
        Client First();
        Client Next();
        bool IsDone { get; }
    }
}
