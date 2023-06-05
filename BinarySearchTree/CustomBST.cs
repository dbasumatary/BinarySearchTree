using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class CustomBST
    {
        private class Node
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

    }
}
