using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        //memeber variables
        Node head;
        //constructor

        //member methods
        public void Add(int data)
        {
            if(head == null)
            {
                head = new Node(data);
            }

            Node current = head;
            bool nodeAdded = false;

            while (!nodeAdded)
            {
                if (data < current.data)
                {
                    if (current.left == null)
                    {
                        current.left = new Node(data);
                        nodeAdded = true;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new Node(data);
                        nodeAdded = true;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
        }
        public Node Search(int data)
        {
            Node current = head;

            while (current != null)
            {
                if (current.data == data)
                {
                    return current;
                }
                if (data < current.data)
                {
                    current = current.left;
                    Console.WriteLine("Left");
                }
                else
                {
                    current = current.right;
                    Console.WriteLine("Right");
                }
            }
            return null;
        }
    }
}
