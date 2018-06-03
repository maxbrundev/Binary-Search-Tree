using System;

namespace BinaryTree
{
    class BST
    {
        public Node m_node;

        public Node Add(int p_key, string p_value)
        {
            if (m_node == null)
            {
                m_node = new Node(p_key, p_value);
                return m_node;
            }
            return SetValue(p_key, p_value);
        }

        public Node SetValue(int p_key, string p_value)
        {
            if (m_node.m_key == p_key)
            {
                m_node.m_value = p_value;
                return m_node;
            }

            m_node = Insert(ref m_node, p_key, p_value);

            return m_node;
        }

        private Node Insert(ref Node p_node, int p_key, string p_value)
        {
            if (p_node == null)
            {
                p_node = new Node(p_key, p_value);
                return p_node;
            }

            if (p_key < p_node.m_key)
                p_node.m_left = Insert(ref p_node.m_left, p_key, p_value);

            else if (p_key > p_node.m_key)
                p_node.m_right = Insert(ref p_node.m_right, p_key, p_value);

            return p_node;
        }

        public Node Search(ref Node p_node, int p_key)
        {
            if (p_node == null || p_node.m_key == p_key)
                return p_node;

            if (p_node.m_key > p_key)
                return Search(ref p_node.m_left, p_key);

            return Search(ref p_node.m_right, p_key);
        }

        public string GetValue(int key)
        {
            m_node.m_key = key;

            return m_node.m_value;
        }

        public bool Remove(int p_key)
        {
            if (m_node == null)
                return false;

            m_node = DeleteNode(ref m_node, p_key);

            return true;
        }

        private Node DeleteNode(ref Node p_node, int p_key)
        {
            if (p_node == null)
                return p_node;

            if (p_key < p_node.m_key)
                p_node.m_left = DeleteNode(ref p_node.m_left, p_key);

            else if (p_key > p_node.m_key)
                p_node.m_right = DeleteNode(ref p_node.m_right, p_key);

            else
            {
                if (p_node.m_left == null)
                    return p_node.m_right;

                else if (p_node.m_right == null)
                    return p_node.m_left;

                p_node.m_key = minValue(ref p_node.m_right);

                p_node.m_right = DeleteNode(ref p_node.m_right, p_node.m_key);
            }
            return p_node;
        }

        private int minValue(ref Node root)
        {
            int minv = root.m_key;
            while (root.m_left != null)
            {
                minv = root.m_left.m_key;
                root = root.m_left;
            }
            return minv;
        }

        public void Display(ref Node p_node)
        {
            if (p_node != null)
            {
                Display(ref p_node.m_left);
                Console.WriteLine("Node key: {0} ", p_node.m_key);
                Display(ref p_node.m_right);
            }
        }

        public void ReverseDisplay(ref Node p_node)
        {
            if (p_node != null)
            {
                ReverseDisplay(ref p_node.m_right);
                Console.WriteLine("{0}", p_node.m_key);
                ReverseDisplay(ref p_node.m_left);
            }
        }

        public void Clear(ref Node p_node)
        {
            if (p_node == null)
                return;

            if (p_node.m_left != null)
                Clear(ref p_node.m_left);
            if (p_node.m_right != null)
                Clear(ref p_node.m_right);

            p_node = null;
        }
    }
}