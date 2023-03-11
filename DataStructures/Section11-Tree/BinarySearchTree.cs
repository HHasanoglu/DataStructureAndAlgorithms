using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinarySearchTree
    {
        #region Ctor

        public BinarySearchTree()
        {
        }

        #endregion

        #region Private Fields

        private TreeNode _root;

        public TreeNode Root { get => _root; set => _root = value; }

        #endregion

        #region Public Methods
        public static void Run()
        {
            var binarySearch = new BinarySearchTree();
            binarySearch.Insert(1);
            binarySearch.Insert(2);
            binarySearch.Insert(6);
            binarySearch.Insert(4);
            binarySearch.InOrder(binarySearch.Root);
            binarySearch.PreOrder(binarySearch.Root);
            binarySearch.PostOrder(binarySearch.Root);
            binarySearch.Serach(6);
            var value=binarySearch.SerachRecursive(binarySearch.Root,6);

        }

        public void Insert(int value) 
        {
            var tempRoot = _root;
            TreeNode temp=null;
            while (tempRoot!=null)
            {
                temp = tempRoot;
                if (tempRoot.Value==value)
                {
                    return;
                }
                else if(value<tempRoot.Value)
                {
                    tempRoot = tempRoot.Left;
                }
                else
                {
                    tempRoot = tempRoot.Right;
                }
            }

            var node = new TreeNode(value);
            if (temp!=null)
            {
                if (value<temp.Value)
                {
                    temp.Left = node;
                }
                else
                {
                    temp.Right = node;
                }
            }
            else
            {
                _root = node;
            }
        }

        public bool Serach(int key) 
        {
            var tempRoot = _root;
            while (tempRoot!=null)
            {
                if (tempRoot.Value==key)
                {
                    return true;
                }

                if (key<tempRoot.Value)
                {
                    tempRoot = tempRoot.Left;
                }
                else
                {
                    tempRoot = tempRoot.Right;
                }
            }
            return false;
        }

        public bool SerachRecursive(TreeNode root, int key)
        {
            var tempRoot = root;
            if (tempRoot != null)
            {
                if (key== tempRoot.Value)
                {
                    return true;
                }

                if (key< tempRoot.Value)
                {
                    return SerachRecursive(tempRoot.Left, key);
                }
                else
                {
                    return SerachRecursive(tempRoot.Right, key);
                }
            }
            return false;
        }

        public void InOrder(TreeNode tempNode) 
        {
            if (tempNode != null)
            {
                InOrder(tempNode.Left);
                Console.WriteLine(tempNode.Value);
                InOrder(tempNode.Right);
            }
        }
        public void PreOrder(TreeNode tempNode)
        {
            if (tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                InOrder(tempNode.Left);
                InOrder(tempNode.Right);
            }
        }
        public void PostOrder(TreeNode tempNode)
        {
            if (tempNode != null)
            {
                InOrder(tempNode.Left);
                InOrder(tempNode.Right);
                Console.WriteLine(tempNode.Value);
            }
        }
        #endregion

    }
}
