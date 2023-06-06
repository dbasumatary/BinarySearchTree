using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class CustomBST
    {
        public class Node
        {
            public int Data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.Data = data;
            }
        }
        private Node Root;

        public Node ReturnRoot()
        {
            return Root;
        }

        //UC1 - Add method in BST
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(Root == null)
            {
                Root = newNode;
                return;
            }
            Node temp = Root;

            while(temp != null)
            {
                if (newNode.Data < temp.Data)
                {
                    if (temp.left == null)
                    {
                        temp.left = newNode;
                        return;
                    }
                    temp = temp.left;
                }
                else if (newNode.Data > temp.Data)
                {
                    if(temp.right == null)
                    {
                        temp.right = newNode;
                        return;
                    }
                    temp = temp.right;
                }
                else
                {
                    Console.WriteLine($"{data} is already present in the tree.");
                    return;
                }
            }
        }

        //UC2 - Search method in BST
        public bool Search(int data)
        {
            if (Root == null)
            {
                Console.WriteLine("\nThe binary tree is empty");
                return false;
            }

            Node temp = Root;

            while (temp != null)
            {
                if (data == temp.Data)
                {
                    return true;
                }
                else if (data < temp.Data)
                {
                    temp = temp.left;
                }
                else if (data > temp.Data)
                {
                    temp = temp.right;
                }
            }
            return false;
        }

        //UC3 - Preorder traversal in BST
        //For Preorder, we traverse from the root to the left subtree then to the right subtree.
        public void PreorderDisplay(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreorderDisplay(root.left);
                PreorderDisplay(root.right);
            }
        }

        //UC4 - Inorder traversal in BST
        //For Inorder, you traverse from the left subtree to the root then to the right subtree.
        public void InorderDisplay(Node root)
        {
            if(root != null)
            {
                InorderDisplay(root.left);
                Console.Write(root.Data + " ");
                InorderDisplay(root.right);
            }
        }
    }
}
