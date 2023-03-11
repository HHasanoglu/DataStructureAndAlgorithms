using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class TreeNode
    {

        #region Ctor

            public TreeNode(int element, TreeNode left=null, TreeNode right=null)
            {
                _value = element;
                _left = left;
                _right = right;
            }

        #endregion

        #region Private Fields

            private int _value;
            private TreeNode _left;
            private TreeNode _right;

        #endregion

        #region Public Properties

        public int Value { get => _value; set => _value = value; }
        public TreeNode Left { get => _left; set => _left = value; }
        public TreeNode Right { get => _right; set => _right = value; }

        #endregion

    }
}
