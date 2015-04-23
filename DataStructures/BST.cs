using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BST<T> where T : IComparable
    {
        private Node root;
        private class Node
        {
            private object data;

            public T Data { get; private set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(T data)
            {
                this.Data = data;
                this.Left = null;
                this.Right = null;
            }
        }

        /// Insertion routines start here.
        public void Put(T data)
        {
            root = Put(root, data);
        }

        private Node Put(Node current, T data)
        {
            if (current == null) current = new Node(data);
            else if (Less(data, current.Data)) current.Left = Put(current.Left, data);
            else current.Right = Put(current.Right, data);

            return current;
        }

        private static bool Less(T t1, T t2)
        {
            return t1.CompareTo(t2) < 0;
        }

        private static bool More(T t1, T t2)
        {
            return t1.CompareTo(t2) > 0;
        }

        public List<T> InorderRecursive()
        {
            List<T> items = new List<T>();
            InorderRecursive(root, items);

            return items;
        }

        private void InorderRecursive(Node current, List<T> items)
        {
            if (current == null) return;
            InorderRecursive(current.Left, items);
            items.Add(current.Data);
            InorderRecursive(current.Right, items);
        }
        /*public List<T> InorderIterative()
        {
        }

        public List<T> PreOrderRecursive()
        {

        }

        public List<T> PreOrderIterative()
        {

        }

        public List<T> PostOrderRecursive()
        {

        }

        public List<T> PostOrderIterative()
        {

        }*/

        public bool IsBST()
        {
            // I do not know how to get min and max value of generics. But you get the idea.

            return true;
        }

        private bool IsBST(Node current, T min, T max)
        {
            bool result;
            if (root == null) result = true;
            if (!(Less(min, current.Data) && Less(current.Data, max))) result = false;
            else result = IsBST(current.Left, min, current.Data) && IsBST(current.Right, current.Data, max);

            return result;
        }

        public bool IsBSTInorder()
        {
            List<T> inorder = this.InorderRecursive();
            return IsAscending(inorder);
        }

        private bool IsAscending(List<T> inorder)
        {
            if (inorder.Count > 0)
            {
                T previous = inorder[0];
                for (int i = 1; i < inorder.Count; i++)
                {
                    if (!Less(previous, inorder[i])) return false;

                    previous = inorder[i];
                }
            }

            return true;
        }
    }
}
