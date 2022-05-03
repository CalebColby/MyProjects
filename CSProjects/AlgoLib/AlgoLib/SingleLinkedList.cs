using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    public class SingleLinkedList<T>
    {
        public int Count { get; private set; } = 0;

        private Node<T>? Head = null;

        public SingleLinkedList()
        {

        }

        public SingleLinkedList(T val)
        {
            Add(val);
        }


        public override string ToString()
        {
            return base.ToString();
        }

        public void Add(T val)
        {
            var newNode = new Node<T>(val);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Count++;
        }

        public void Insert(T val, int index)
        {
            if(index >= Count || index < 0) throw new IndexOutOfRangeException();
            
            var newNode = new Node<T>(val);

            if(index == 0)
            {
                this.Push(val);
                return;
            }

            var current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;

            Count++;
            throw new NotImplementedException();
        }

        public void Push(T val)
        {
            var newNode = new Node<T>(val);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public T Get(int index)
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();

            throw new NotImplementedException();
        }

        public T Remove()
        {
            throw new NotImplementedException();
        }

        public T RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public T RemoveLast()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public int Search(T val)
        {
            throw new NotImplementedException();
        }
    }
}
