using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public int Count { get; private set; } = 0;

        private BSTNode<T>? root { get; set; } = null;

        public void Add(T val)
        {
            if (root == null)
            {
                root = new BSTNode<T>(val);
                Count++;
            }
            else
            {
                Add(val, root);
            }
        }

        private void Add(T val, BSTNode<T> current)
        {
            if (val.CompareTo(current.Data) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = new BSTNode<T>(val);
                    Count++;
                }
                else
                {
                    Add(val, current.Left);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = new BSTNode<T>(val);
                    Count++;
                }
                else
                {
                    Add(val, current.Right);
                }
            }
        }

        public bool Contains(T val)
        {
            return Contains(val, root);
        }

        private bool Contains(T val, BSTNode<T> current)
        {
            if (current == null) return false;
            if (val.CompareTo(current.Data) == 0) return true;
            if (val.CompareTo(current.Data) < 0)
            {
                return Contains(val, current.Left);
            }
            else
            {
                return Contains(val, current.Right);
            }

        }

        public void Remove(T val)
        {
            if (root == null) return;
            if (val.Equals(root.Data))
            {
                var orphan = root.Right;
                root = root.Left;
                if (orphan != null)
                {
                    var current = root;
                    while(current.Right != null)
                    {
                        current = current.Right;
                    }
                    current.Right = orphan;
                }
                Count--;
            }
            else
            {
                Remove(val, root);
            }
            
        }

        private void Remove(T val, BSTNode<T> current)
        {
            if(val.CompareTo(current.Data) < 0)
            {
                if (current.Left.Data.Equals(val))
                {
                    RemoveLeft(current);
                    Count--;
                }
                else
                {
                    Remove(val, current.Left);
                }
            }
            else
            {
                if (current.Right.Data.Equals(val))
                {
                    RemoveRight(current);
                    Count--;
                }
                else
                {
                    Remove(val, current.Right);
                }
            }
        }

        private void RemoveLeft(BSTNode<T> parent)
        {
            if (IsLeaf(parent.Left))
            {
                parent.Left = null;
            }
            else
            {
                var orphan = parent.Left.Right;
                parent.Left = parent.Left.Left;
                if(orphan != null)
                {
                    var current = parent.Left;
                    while(current.Right != null)
                    {
                        current = current.Right;
                    }
                    current.Right = orphan;
                }
            }
        }
        
        private void RemoveRight(BSTNode<T> parent)
        {
            if (IsLeaf(parent.Right))
            {
                parent.Right = null;
            }
            else
            {
                var orphan = parent.Right.Left;
                parent.Right = parent.Right.Right;
                if(orphan != null)
                {
                    var current = parent.Right;
                    while (current.Left != null)
                    {
                        current = current.Left;
                    }
                    current.Left = orphan;
                }
            }
        }

        private bool IsLeaf(BSTNode<T> current)
        {
            if (current == null) throw new ArgumentException();
            if (current.Left == null || current.Right == null) return true;
            return false;
        }

        private List<T> GetChildren(List<T> children, BSTNode<T> parent)
        {
            if(parent.Left != null)
            {
                children.Add(parent.Left.Data);
                children = GetChildren(children, parent.Left);
            }
            if(parent.Right != null)
            {
                children.Add(parent.Right.Data);
                children = GetChildren(children, parent.Right);
            }
            return children;
        }

        public void Clear()
        {
            Count = 0;
            root = null;
        }

        public int Height()
        {
            if (Count == 0) return Count;
            return Height(1, root);
        }

        private int Height(int cHeight, BSTNode<T> current)
        {
            if (current == null) return cHeight - 1;

            int LH = Height(cHeight + 1, current.Left);
            int RH = Height(cHeight + 1, current.Right);

            return LH > RH ? LH : RH;
        }


        public T[] ToArray()
        {
            if(root == null) return new T[0];

            T[] arr = new T[Count];
            
            ToArray(arr, root, 0);

            return arr;
        }

        

        private int ToArray(T[] arr, BSTNode<T> current, int index)
        {
            if(current == null) return index;
            index = ToArray(arr, current.Left, index);
            arr[index] = current.Data;
            index++;
            index = ToArray(arr, current.Right, index);
            return index;
        }

       

        public string InOrder()
        {
            if(root == null) return default(string);
            return InOrder(new StringBuilder(""), root).ToString();
        }

        private StringBuilder InOrder(StringBuilder val, BSTNode<T> current)
        {
            if(current == null) return val;
            val = InOrder(val, current.Left);
            if (val.ToString() == "")
            {
                val.Append($"{current.Data}");
            }
            else
            {
                val.Append($", {current.Data}");
            }
            val = InOrder(val, current.Right);
            return val;
            
        }

        public string PreOrder()
        {
            if (root == null) return default(string);
            return PreOrder(new StringBuilder(""), root).ToString();
        }

        private StringBuilder PreOrder(StringBuilder val, BSTNode<T> current)
        {
            if (current == null) return val;
            if (val.ToString() == "")
            {
                val.Append($"{current.Data}");
            }
            else
            {
                val.Append($", {current.Data}");
            }
            val = PreOrder(val, current.Left);
            val = PreOrder(val, current.Right);
            return val;

        }

        public string PostOrder()
        {
            if (root == null) return default(string);
            return PostOrder(new StringBuilder(""), root).ToString();
        }

        private StringBuilder PostOrder(StringBuilder val, BSTNode<T> current)
        {
            if (current == null) return val;
            val = PostOrder(val, current.Left);
            val = PostOrder(val, current.Right);
            if (val.ToString() == "")
            {
                val.Append($"{current.Data}");
            }
            else
            {
                val.Append($", {current.Data}");
            }
            return val;
        }

        public BinarySearchTree()
        {

        }

        public BinarySearchTree(T val)
        {
            this.Add(val);
        }

        public BinarySearchTree(IEnumerable<T> vals)
        {
            var valsEnum = vals.GetEnumerator();
            do
            {
                this.Add(valsEnum.Current);
            } while (valsEnum.MoveNext());
        }
    }
}
