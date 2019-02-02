using System;

namespace AlgorithmsAndDataStructures.DataStructures.Trees.BinaryTree
{
    internal class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }

        public TNode Value { get; }

        public BinaryTreeNode<TNode> Left { get; set; }
        public BinaryTreeNode<TNode> Right { get; set; }

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }
}