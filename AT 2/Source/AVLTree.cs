using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nicholas Brown
//30032159

//AVL Tree code sourced from SMTAFE blackboard website.

namespace PayrollProject
{
    class AVLTree
    {
        class Node
        {
            public string data;
            public Node left;
            public Node right;
            public Node(string data)
            {
                this.data = data;
            }
        }

        Node root;

        public string GetRoot()
        {
            try
            {
                return root.data;
            }
            catch
            {
                return "Error";
            }
            
        }
        

        public AVLTree() { }

        // Add new data to tree node and re-balance
        // uses the Balance_Tree and Rotate methods
        public void Add(string data)
        {
            Node newItem = new Node(data);
            if (root == null)
                root = newItem;
            else
                root = AddRecursive(root, newItem);
        }
        private Node AddRecursive(Node current, Node n)
        {
            if (current == null)
            {
                current = n;
                return current;
            }
            else if (string.Compare(n.data, current.data) < 0)
            {
                current.left = AddRecursive(current.left, n);
                current = Balance_Tree(current);
            }
            else if (string.Compare(n.data, current.data) > 0)
            {
                current.right = AddRecursive(current.right, n);
                current = Balance_Tree(current);
            }
            return current;
        }

        public void Delete(string target)
        {
            root = DeleteNode(root, target);
        }
        private Node DeleteNode(Node current, string target)
        {
            Node parent;
            if (current == null)
            { return null; }
            else
            {
                //left subtree
                if (string.Compare(target, current.data) < 0)
                {
                    current.left = DeleteNode(current.left, target);
                    if (Balance_Factor(current) == -2)//here
                    {
                        if (Balance_Factor(current.right) <= 0)
                        {
                            current = RotateRR(current);
                        }
                        else
                        {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (string.Compare(target, current.data) > 0)
                {
                    current.right = DeleteNode(current.right, target);
                    if (Balance_Factor(current) == 2)
                    {
                        if (Balance_Factor(current.left) >= 0)
                        {
                            current = RotateLL(current);
                        }
                        else
                        {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else
                {
                    if (current.right != null)
                    {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        current.data = parent.data;
                        current.right = DeleteNode(current.right, parent.data);
                        if (Balance_Factor(current) == 2)//rebalancing
                        {
                            if (Balance_Factor(current.left) >= 0)
                            {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else
                    {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }

        // Methods to balance tree after insert and delete
        private Node Balance_Tree(Node current)
        {
            int b_factor = Balance_Factor(current);
            if (b_factor > 1)
            {
                if (Balance_Factor(current.left) > 0)
                {
                    current = RotateLL(current);
                }
                else
                {
                    current = RotateLR(current);
                }
            }
            else if (b_factor < -1)
            {
                if (Balance_Factor(current.right) > 0)
                {
                    current = RotateRL(current);
                }
                else
                {
                    current = RotateRR(current);
                }
            }
            return current;
        }
        private int Balance_Factor(Node current)
        {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
        private int max(int l, int r)
        {
            return l > r ? l : r;
        }
        private int getHeight(Node current)
        {
            int height = 0;
            if (current != null)
            {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = max(l, r);
                height = m + 1;
            }
            return height;
        }

        public string Find(string key)
        {
            try
            {
                if (FindRecursive(key, root).data == key)
                {
                    return (key + " was found!");
                }
            }
            catch
            {
                return "Nothing found!";
            }
            return "Nothing found!";

        }
        private Node FindRecursive(string target, Node current)
        {

            if (string.Compare(target, current.data) < 0)
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return FindRecursive(target, current.left);
            }
            else
            {
                if (target == current.data)
                {
                    return current;
                }
                else
                    return FindRecursive(target, current.right);
            }
        }

        public string Display()
        {
            if (root == null)
            {
                return "Tree is empty";
            }

            return DisplayInOrder(root);
        }
        private string DisplayInOrder(Node current)
        {
            string s = "";
            if (current != null)
            {
                s = DisplayInOrder(current.left);
                s += current.data;
                s += " ";
                s += DisplayInOrder(current.right);
            }
            return s;
        }
    }
}
