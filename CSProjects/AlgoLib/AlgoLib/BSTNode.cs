using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    internal class BSTNode<T> where T : IComparable<T>
    {
        internal BSTNode<T>? Left { get; set; } = null;
        internal BSTNode<T>? Right { get; set; } = null;

        public readonly T Data;

        public BSTNode(T val)
        {
            Data = val;
        }
    }
}
