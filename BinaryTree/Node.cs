namespace BinaryTree
{
    class Node
    {
        public int m_key;
        public string m_value;
        public Node m_left;
        public Node m_right;

        public Node(int p_key, string p_value)
        {
            m_key = p_key;
            m_value = p_value;
            m_left = null;
            m_right = null;
        }
    }
}