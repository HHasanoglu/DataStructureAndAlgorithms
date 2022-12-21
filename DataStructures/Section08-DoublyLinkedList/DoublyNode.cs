using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class DoublyNode
    {
        #region Ctor
        public DoublyNode(int element, DoublyNode previous, DoublyNode next)
        {
            _element = element;
            _previous = previous;
            _next = next;
        }

        #endregion

        #region Private Fields

        private int _element;
        private DoublyNode _previous;
        private DoublyNode _next;

        #endregion

        #region Public Properties

        public int Element { get => _element; set => _element = value; }
        internal DoublyNode Previous { get => _previous; set => _previous = value; }
        internal DoublyNode Next { get => _next; set => _next = value; }

        #endregion

    }
}
