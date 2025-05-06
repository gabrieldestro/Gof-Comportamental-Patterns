using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Iterator.Aggregate;

namespace Iterator.Iterator
{
    public class ConcreteIterator : IAbstractIterator
    {

        private int _current = 0;
        private int _step = 1;

        private ConcreteCollection _collection;

        public ConcreteIterator(ConcreteCollection collection)
        {
            _collection = collection;
        }

        public bool IsDone 
        {
            get { return _current >= _collection.Count; }
        }

        public Client First()
        {
            _current = 0;
            return _collection.GetClient(_current);
        }

        Client IAbstractIterator.First()
        {
            throw new NotImplementedException();
        }

        public Client Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection.GetClient(_current);
            else
                return null;
        }

        Client IAbstractIterator.Next()
        {
            throw new NotImplementedException();
        }
    }
}
