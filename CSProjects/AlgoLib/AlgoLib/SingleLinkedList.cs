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
            this.Add(val);
        }

        public SingleLinkedList(IEnumerable<T> vals)
        {
            var valsEnum = vals.GetEnumerator();
            do
            {
                this.Add(valsEnum.Current);
            }while (valsEnum.MoveNext());
            
        }


        public override string ToString()
        {
            if(Head == null) return string.Empty;
            if(Count == 1) return Head.Data.ToString();

            StringBuilder sb = new StringBuilder($"{Head.Data}");

            var current = Head;
            while(current.Next != null)
            {
                current = current.Next;
                sb.Append($", {current.Data}");    
            }

            return sb.ToString();
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
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();
            //if (index == Count) { this.Add(val); return; }
            if (index == 0) { this.Push(val); return; }

            var newNode = new Node<T>(val);

            var current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;

            Count++;
        }

        public void Push(T val)
        {
            if (Count == 0) { this.Add(val); return; }
            var newNode = new Node<T>(val);
            newNode.Next = Head;
            Head = newNode;
            Count++;
        }

        public T Get(int index)
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();
            var current = Head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public T Remove()
        {
            if (Head == null) return default(T);
            T val = Head.Data;

            Head = Head.Next;
            Count--;

            return val;
        }

        public T RemoveAt(int index)
        {
            if (index >= Count || index < 0) throw new IndexOutOfRangeException();
            if (index == 0) return Remove();

            var current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            T val = current.Next.Data;

            current.Next = current.Next.Next;
            Count--;
            return val;
        }

        public T RemoveLast()
        {
            if (Head == null) return default(T);
            if (Count == 1) return Remove();
            if (Count == 2) return RemoveAt(1);

            var current = Head;
            while(current.Next.Next != null) current = current.Next;
            T val = current.Next.Data;
            current.Next = null;
            Count--;

            return val;
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public int Search(T val)
        {
            if(Head == null) return -1;
            var current = Head;
            for (int i = 0; i < Count; i++)
            {
                if (current.Data.Equals(val)) return i;
                current = current.Next;
            }
            return -1;
        }
    }
}
