using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    internal class Node<T>
    {
        internal T Data { get; set; }

        internal Node<T>? Next { get; set; }
        internal Node<T>? Previous { get; set; }


        internal Node(T val)
        {
            this.Data = val;
        }
    }
}
