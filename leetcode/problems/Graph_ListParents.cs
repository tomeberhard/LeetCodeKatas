

using System;

//using NUnit.Framework;
//using NUnitLite;
using System.Reflection;
using System.Text;

using System.Collections.Generic;

public class Graph_ListParents
{
    /*
     * You are given an input string that lists nodes and children
     * A node may have several children
     * There might be a ring
     * Input format
     *      "a->b;b->c;c->d;b->d
     * Program has to list each node, and its parents on a line.
     * For example above, correct output is as follows:
     *      a:
     *      b: a
     *      c: b
     *      d: b, c
    */

    public class Node
    {
        public String name;
        public List<Node> children;
        public List<Node> parents;

        public Node(string newName)
        {
            name = newName;
            children = new List<Node>();
            parents = new List<Node>();
        }
    }


    Dictionary<string, Node> nodeMap;

    public Graph_ListParents()
    {
        nodeMap = new Dictionary<string, Node>();
    }


    public String Parse(string inputRepresentation)
    {
        StringBuilder sb = new StringBuilder();


        sb.AppendLine(inputRepresentation);

        ParseString(inputRepresentation);   //fills the class NodeMap
        // nodeMap = {a: Node, b: Node, c: Node, d: Node}


        // for n in nodeMap.values: print n.name, n.parents

        foreach (string nodeName in nodeMap.Keys)
        {
            sb.Append(nodeMap[nodeName].name + ": ");
            //Console.Out.Write(nodeMap[nodeName].name + ": ");
            int parentCount = nodeMap[nodeName].parents.Count;
            int count = 1;
            foreach (Node parentNode in nodeMap[nodeName].parents)
            {
                sb.Append(parentNode.name);
                //Console.Out.Write(parentNode.name);
                if (count < parentCount)
                {
                    count++;
                    sb.Append(", ");
                    //Console.Out.Write(", ");
                }
            }
            sb.AppendLine();
            Console.Out.WriteLine();

        }
        return sb.ToString();
    }

    private Node ParseString(String inputString)
    {

        // a->b;b->c;c->d;b->d
        String[] separator = { ";" };

        string[] tokens = inputString.Split(separator, StringSplitOptions.None);

        foreach (string s in tokens)
        {
            String[] arrow = { "->" };
            string[] rawNode = s.Split(arrow, StringSplitOptions.None);

            if (nodeMap.ContainsKey(rawNode[0]))
            {
                Node node1;
                if (!nodeMap.ContainsKey(rawNode[1]))
                {
                    node1 = new Node(rawNode[1]);
                    nodeMap.Add(rawNode[1], node1);
                }
                else
                {
                    node1 = nodeMap[rawNode[1]];
                }
                Node node0 = nodeMap[rawNode[0]];
                node0.children.Add(node1);
                node1.parents.Add(node0);
            }
            else
            {
                Node node0 = new Node(rawNode[0]);
                nodeMap.Add(rawNode[0], node0);

                Node node1;
                if (!nodeMap.ContainsKey(rawNode[1]))
                {
                    node1 = new Node(rawNode[1]);
                    nodeMap.Add(rawNode[1], node1);
                }
                else
                {
                    node1 = nodeMap[rawNode[1]];
                }
                node0.children.Add(node1);
                node1.parents.Add(node0);
            }

        }

        return null;
    }


    public class Runner
    {
        public static int MainRunner(string[] args)
        {
            // return new AutoRun(Assembly.GetCallingAssembly()).Execute(new String[] { "--labels=All" });
            return -1;
        }

        // NUnit: [TestFixture]
        public class Foo
        {
            // NUnit: [Test]
            public void TestSomething()
            {
                //Assert.AreEqual(2, 2);
            }
        }

    }

}
