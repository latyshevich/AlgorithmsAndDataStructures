using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndDataStructures.DataStructures.Trees.BinaryTree
{
    /// <summary>
    ///     Двоичное дерево поиска
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class BinaryTreeSearch<T> : IEnumerable<T> where T : IComparable<T>
    {
        private int _count;
        private BinaryTreeNode<T> _head;

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            if (_head == null)
                _head = new BinaryTreeNode<T>(value);
            else
                AddTo(_head, value);
            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            if (node.CompareTo(value) < 0)
            {
                if (node.Left == null)
                    node.Left = new BinaryTreeNode<T>(value);
                else
                    AddTo(node.Left, value);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new BinaryTreeNode<T>(value);
                else
                    AddTo(node.Right, value);
            }
        }

        public bool Remove(T value)
        {
            BinaryTreeNode<T> parent;
            var current = FindWithParent(value, out parent);
            if (current == null)
                return false;
            _count--;

            if (current.Right == null)
                if (parent == null)
                    _head = current.Left;
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            BinaryTreeNode<T> parent;
            return FindWithParent(value, out parent) != null;
        }

        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            var current = _head;
            parent = null;
            while (current != null)
            {
                var compare = current.CompareTo(value);
                if (compare > 0)
                {
                    parent = current;
                    current = parent.Left;
                }
                else if (compare > 0)
                {
                    parent = current;
                    current = parent.Right;
                }
                else
                {
                    break;
                }
            }

            return current;
        }
    }
}