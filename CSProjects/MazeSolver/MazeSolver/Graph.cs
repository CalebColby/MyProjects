using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class Graph
    {
        public List<GraphNode> Nodes = new List<GraphNode>();
        public List<GraphNode> Solution = new List<GraphNode>();
        private GraphNode StartNode;
        private GraphNode EndNode;
        private bool Solved = false;

        public Graph(string[] blueprints)
        {
            foreach(string nodeBP in blueprints[0].Split(","))
            {
                Nodes.Add(new GraphNode(nodeBP));
            }
            string[] entryExitNodes = blueprints[1].Split(",");
            if (entryExitNodes.Length != 2) throw new ArgumentException();
            foreach(GraphNode node in Nodes)
            {
                if(node.Name == entryExitNodes[0])
                {
                    StartNode = node;
                }
                if(node.Name == entryExitNodes[1])
                {
                    EndNode = node;
                }
            }
            for (int i = 2; i < blueprints.Length; i++)
            {
                if (!blueprints[i].Contains("\\\\"))
                {
                    string[] connects = blueprints[i].Split(",");
                }
            }
        }

        public void Solve()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
