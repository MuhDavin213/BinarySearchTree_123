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
                tmp = new node(element, null, null);
                if(parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element,parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rChild = tmp;
                }
            }
        }
        public void find(string element, ref node parent, ref node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.lchild;
                else
                    currentnode = currentnode.rChild;
            }
        }
        public void inorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info +"");
                inorder(ptr.rChild);
            }
        }
        public void preorder(node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("tree is empty");
                return;
            }
            if(ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.lchild);
                preorder(ptr.rChild);
            }
        }
        public void Postorder(node ptr)
        {}
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
