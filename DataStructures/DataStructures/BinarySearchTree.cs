using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.DataStructures
{
    internal class BinarySearchTree : BinaryTree
    {
        // non linear data structure that has the following features:
        // 1 - The left subtree of a node contains only nodes with keys lesser than the node’s key.
        // 2 - The right subtree of a node contains only nodes with keys greater than the node’s key.
        // 3 - The left and right subtree each must also be a binary search tree.
        // 4 - There must be no duplicate nodes with the same key.

        public BTNode? root { get; set; }

        public BinarySearchTree()
        {
            root = null;
        }
        public BinarySearchTree(int value)
        {
            root = new BTNode(value);
        }
        public BTNode Search(BTNode root, int key)
        {
            // empty tree or key to look for is root value
            if (root == null || root.key == key)
                return root;

            // since it is a BST, we go right if the key to search is greater than root key
            if (root.key < key)
                return Search(root.right, key);
            return Search(root.left, key);
        }

        public void Delete(int key)
        {

        }

        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        private BTNode InsertRec(BTNode root, int key)
        {
            // if the tree is empty, create the first node
            // or at the end of recursion, it creates the new node after reaching the leaves of the tree
            if (root is null)
            {
                root = new BTNode(key);
                return root;
            }

            // go down into the tree depending on which side the key is on, following BST rules
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else
                root.right = InsertRec(root.right, key);

            return root;
        }
    }
}
