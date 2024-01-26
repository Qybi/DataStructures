using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DataStructures
{
    internal class BinaryTree
    {
        // non linear data structure that has either 0, 1 or 2 children nodes.
        public BTNode Head { get; set; }

        #region Traversing
        // ========= TRAVERSING =========
        // DFS : Depth-first Search
        // Recursive Inorder approach (left-current-right): 
        public void InorderTraversing(BTNode node)
        {
            if (node == null) return;
            // recur on left side of the tree
            InorderTraversing(node.left);
            Console.Write(node.key + " ");
            // recur on right side of the tree
            InorderTraversing(node.right);
        }

        // Recursive Preorder approach (current-left-right):
        public void PreorderTraversing(BTNode node)
        {
            if (node is null) return;
            
            Console.Write(node.key + " ");
            // recur on left side of the tree
            PreorderTraversing(node.left);
            // recur on right side of the tree
            PreorderTraversing(node.right);
        }

        // Recursive Postorder approach (left-right-root):
        // first traverse all the left subtrees, then the right, then visit the root.
        public void PostorderTraversing(BTNode node)
        {
            if (node is null) return;

            // recur on left side of the tree
            PostorderTraversing(node.left);
            // recur on right side of the tree
            PostorderTraversing(node.right);
            Console.Write(node.key + " ");
        }
        #endregion
    }

    internal class BTNode
    {
        public int? key { get; set; }
        public BTNode? left { get; set; }
        public BTNode? right { get; set; }
        public BTNode(int value)
        {
            left = right = null;
            key = value;
        }
        public override string ToString()
        {
            return $"key is {key}";
        }
    }
}
