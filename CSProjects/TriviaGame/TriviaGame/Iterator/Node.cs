using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame.Iterator
{
    public class Node<T>
    {
        public T Value { get; private set; }

        public bool isLeaf { get; private set; } = true;

        public List<Node<T>> children { get; } = new List<Node<T>>();

        public void addChild(T newChild)
        {
            if (isLeaf)
            {
                children.Add(new Node<T>(newChild));
                isLeaf = false;
                return;
            }
            var randy = new System.Random();
            if (randy.Next(2) == 0)
            {
                children.Add(new Node<T>newChild));
            }
        }

        public Node(T value)
        {
            Value = value;
        }
    }
}
