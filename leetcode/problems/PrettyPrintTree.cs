using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.problems
{

    // Tom Eberhard (tom.eberhard@gmail.com)
    // Tech screen with Wilkin Health
    //
    //       2
    //    7     5
    // 2     6      9
    //      5 11   4
    // 

    public static class PrettyPrintTree
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            // public int level;        // turns out it's actually not needed, Traverse() tracks the levels automatically

            public Node(int newValue)
            {
                value = newValue;
            }
        }

        public static int treeDepth = 0;

        public static Node CreateTree()
        {
            Node root = new Node(2);

            Node n7 = new Node(7);
            Node n5 = new Node(5);

            root.left = n7;
            root.right = n5;

            Node n2 = new Node(2);
            Node n6 = new Node(6);
            n7.left = n2;
            n7.right = n6;

            Node n5b = new Node(5);
            Node n11 = new Node(11);
            n6.left = n5b;
            n6.right = n11;

            Node n9 = new Node(9);
            n5.right = n9;

            Node n4 = new Node(4);
            n9.left = n4;

            return root;
        }

        public static string whMain()
        {
            Node root = CreateTree();
            Dictionary<int, List<Node>> nodeMap = new Dictionary<int, List<Node>>();
            Traverse(root, 0, nodeMap);
            string s = PrintTree(nodeMap);
            return s;
        }

        public static void Traverse(Node root, int level, Dictionary<int, List<Node>> nodeMap)
        {
            if (root == null)
            {
                return;
            }

            // root.level = level;     // setting level as we traverse it, not ahead of time (

            // Add this node to the List at the given level
            if (! nodeMap.Keys.Contains(level) )
            {
                nodeMap[level] = new List<Node>();
            }
            nodeMap[level].Add(root);

            // Process left and right sides
            Traverse(root.left, level + 1, nodeMap);
            Traverse(root.right, level + 1, nodeMap);

            // update treeDepth (used in PrintTree)
            if (treeDepth < level)
            {
                treeDepth = level;
            }
        }

        public static string PrintTree(Dictionary<int, List<Node>> nodeMap)
        {
            // Design Note: outer loop prints all the levels, inner loop prints nodes on a level
            // with additional logic to avoid printing trailing whitespace

            StringBuilder sb = new StringBuilder();

            // print all the levels
            for(int level=0; level<=treeDepth; level++)
            {
                int nodesInLevel = nodeMap[level].Count;
                int index = 0;
                // print nodes on this level
                foreach (Node n in nodeMap[level])
                {
                    sb.Append(n.value);
                    index++;
                    if (index < nodesInLevel)
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}