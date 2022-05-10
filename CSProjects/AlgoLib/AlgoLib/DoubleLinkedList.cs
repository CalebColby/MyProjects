using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    public class DoubleLinkedList<T>
    {
        public int Count { get; private set; } = 0;

        private Node<T>? Head = null;
        private Node<T>? Tail = null;

        public override string ToString()
        {
            if (Head == null) return string.Empty;
            if (Count == 1) return Head.Data.ToString();

            StringBuilder sb = new StringBuilder($"{Head.Data}");

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
                sb.Append($", {current.Data}");
            }

            return sb.ToString();
        }

        public void Add(T val)
        {
            if(Tail == null)
            {
                var newNode = new Node<T>(val);
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                var newNode = new Node<T>(val);
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = newNode;
            }
            Count++;
        }

        public void Insert(T val, int index)
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();
            //if (index == Count) { this.Add(val); return; }
            if (index == 0) { this.Push(val); return; }

            if (index < HalfCount())
            {
                var prev = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    prev = prev.Next;
                }
                var next = prev.Next;

                var newNode = new Node<T>(val);
                newNode.Previous = prev;
                newNode.Next = next;
                prev.Next = newNode;
                next.Previous = newNode;
            }
            else
            {
                var next = Tail;
                for (int i = (Count - 1) - index; i > 0; i--)
                {
                    next = next.Previous;
                }
                var prev = next.Previous;

                var newNode = new Node<T>(val);
                newNode.Previous = prev;
                newNode.Next = next;
                prev.Next = newNode;
                next.Previous = newNode;
            }
            Count++;
        }

        public void Push(T val)
        {
            if(Count == 0) { this.Add(val); return; }
            var newNode = new Node<T>(val);
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
            Count++;
        }

        public T Get(int index) 
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();

            if(index < HalfCount())
            {
                var current = Head;
                for(int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            else
            {
                var current = Tail;
                for (int i = (Count - 1) - index; i > 0; i++)
                {

                }
                return current.Data;
            }
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
            Tail = null;
            Count = 0;
        }

        public int Search(T val)
        {
            if (Head == null) return -1;
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(val)) return i;
                current = current.Next;
            }
            return -1;
        }

        private float HalfCount() { return Count / 2; }
    }
}
