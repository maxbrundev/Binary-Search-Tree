using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Add(30, "c");
            tree.Add(10, "a");
            tree.Add(40, "b");
            tree.Add(80, "c");
            tree.Add(70, "b");
            tree.Add(50, "c");
            tree.Add(60, "b");
            tree.Add(20, "c");

           // tree.SetValue(20, "f");

            //Console.WriteLine(tree.GetValue(10));

            //tree.Remove(10);

            //tree.Search(ref tree.m_node, 30);

            Console.WriteLine("The Tree: \n");
            tree.Display(ref tree.m_node);

            Console.WriteLine("\nDelete node 20");
            tree.Remove(20);
            Console.WriteLine("Modified tree: \n");
            tree.Display(ref tree.m_node);

            Console.WriteLine("\nDelete node 30");
            tree.Remove(30);
            Console.WriteLine("Modified tree: \n");
            tree.Display(ref tree.m_node);

            Console.WriteLine("\nDelete node 50");
            tree.Remove(50);
            Console.WriteLine("Modified tree: \n");
            tree.Display(ref tree.m_node);
 
            tree.Clear(ref tree.m_node);
            Console.WriteLine("Cleared tree: \n");
            tree.Display(ref tree.m_node);
            Console.WriteLine("Add node 3\n");
            tree.Add(3, "z");
            Console.WriteLine("Modified tree:");
            tree.Display(ref tree.m_node);
            Console.ReadKey();
        }
    }
}