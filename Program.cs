using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rChild;

        //constructor for the code clas
        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rChild = r;
        }
    }
    class BinaryTree
    {
        public node ROOT;
        public BinaryTree()
        {
            ROOT = null; //initializing root to null
        }
        public void insert(string element)//insert a node in the binary
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)/**/
            {
                Console.WriteLine("duplicate words not allowed");
                return;
            }
            else/*if the specified node is not present*/
            {

            }
        }
    }
    class Program
    {
        class Binary
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
