using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorTrial.Interfaces
{
    public interface IIterator<T>
    {
        public bool hasNext();

        public T Next();
    }
}
