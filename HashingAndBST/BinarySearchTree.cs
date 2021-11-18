using System;
using System.Collections.Generic;
using System.Text;

    // C# code to add all greater values to
    // every node in a given BST

    // A binary tree node

    public class Node
    {


        public int data;

        public Node left, right;


        public Node(int d)

        {

            data = d;

            left = right = null;

        }
    }


    public class BinarySearchTree
    {


        // Root of BST

        public Node root;


        // Constructor

        public BinarySearchTree()

        {

            root = null;

        }


        // Inorder traversal of the tree

        public virtual void inorder()

        {

            inorderUtil(this.root);

        }


        // Utility function for inorder traversal of

        // the tree

        public virtual void inorderUtil(Node node)

        {

            if (node == null)
            {

                return;

            }


            inorderUtil(node.left);

            Console.Write(node.data + " ");

            inorderUtil(node.right);

        }


        // adding new node

        public virtual void insert(int data)

        {

            this.root = this.insertRec(this.root, data);

        }


        /* A utility function to insert a new node with  

        given data in BST */

        public virtual Node insertRec(Node node, int data)

        {

            /* If the tree is empty, return a new node */

            if (node == null)
            {

                this.root = new Node(data);

                return this.root;

            }


            /* Otherwise, recur down the tree */

            if (data <= node.data)
            {

                node.left = this.insertRec(node.left, data);

            }

            else
            {

                node.right = this.insertRec(node.right, data);

            }

            return node;

        }


        // This class initialises the value of sum to 0

        public class Sum
        {

            private readonly BinarySearchTree outerInstance;


            public Sum(BinarySearchTree outerInstance)

            {

                this.outerInstance = outerInstance;

            }


            public int sum = 0;

        }


        // Recursive function to add all greater values in

        // every node

        public virtual void modifyBSTUtil(Node node, Sum S)

        {

            // Base Case

            if (node == null)
            {

                return;

            }


            // Recur for right subtree

            this.modifyBSTUtil(node.right, S);


            // Now *sum has sum of nodes in right subtree, add

            // root->data to sum and update root->data

            S.sum = S.sum + node.data;

            node.data = S.sum;


            // Recur for left subtree

            this.modifyBSTUtil(node.left, S);

        }


        // A wrapper over modifyBSTUtil()

        public virtual void modifyBST(Node node)

        {

            Sum S = new Sum(this);

            this.modifyBSTUtil(node, S);

        }


        // Driver Function

        public static void Main(string[] args)

        {

            BinarySearchTree tree = new BinarySearchTree();


            /* Let us create following BST 

                  50 

               /     \ 

              30      70 

             /  \    /  \ 

           20   40  60   80 */


            tree.insert(50);

            tree.insert(30);

            tree.insert(20);

            tree.insert(40);

            tree.insert(70);

            tree.insert(60);

            tree.insert(80);


            tree.modifyBST(tree.root);


            // print inorder traversal of the modified BST

            tree.inorder();

        }
    }

