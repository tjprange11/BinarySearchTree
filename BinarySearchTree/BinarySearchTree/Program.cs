using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree binaryTree = new Tree();
            binaryTree.Add(34);
            binaryTree.Add(45);
            binaryTree.Add(27);
            binaryTree.Add(23);
            binaryTree.Add(30);
            binaryTree.Add(37);
            binaryTree.Add(54);
            Node search = binaryTree.Search(40);

            if(search != null)
            {
                Console.WriteLine("Found!!");
            }
            else
            {
                Console.WriteLine("Not Found!");
            }

            Console.ReadLine();
        }
    }
}
