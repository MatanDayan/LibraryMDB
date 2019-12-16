using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMDB
{

    class BST<T> where T : IComparable<T>
    {
        Node root;

        public void Add(T val)
        {
            Node newNode = new Node(val);
            if (root == null)
            {
                root = newNode;
                return;
            }

            Node tmp = root;
            Node parent = null;
            while (tmp != null)
            {
                parent = tmp;
                if (val.CompareTo(tmp.info) < 0) //val < tmp.info
                    tmp = tmp.left;
                else
                    tmp = tmp.right;
            }

            if (val.CompareTo(parent.info) < 0) // add val as left node - val < parent.info
                parent.left = newNode;
            else
                parent.right = newNode;
        }

        public void ScanInOrder(Action<T> action)
        {
            ScanInOrder(root, action);
        }

        private void ScanInOrder(Node currentRoot, Action<T> action)
        {
            if (currentRoot == null) return;

            ScanInOrder(currentRoot.left, action);
            // Console.WriteLine(currentRoot.info);
            action(currentRoot.info);
            ScanInOrder(currentRoot.right, action);
        }

        public int GetDepths()
        {
            return GetDepths(root);
        }

        public bool Remove(T itemToRemove)
        {
            return true;
        }

        private int GetDepths(Node currentRoot)
        {
            if (currentRoot == null) return 0;

            return Math.Max(GetDepths(currentRoot.left), GetDepths(currentRoot.right)) + 1;
        }

        public bool Search(T item, out T foundItem)
        {
            foundItem = default(T);
            Node tmp;
            tmp = root;

            while (tmp != null)
            {

                if (item.CompareTo(tmp.info) == 0)
                {
                    foundItem = tmp.info;
                    return true;
                }
                else if (item.CompareTo(tmp.info) > 0)
                {
                    tmp = tmp.right;
                }
                else
                {
                    tmp = tmp.left;
                }

            }

        }




    }

    class Node
    {
        public T info;
        public Node left;
        public Node right;

        public Node(T info)
        {
            this.info = info;
            left = right = null;
        }
    }
}



