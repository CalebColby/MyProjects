using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    public class GraphNode
    {
        public List<GraphNode> Connections;
        public readonly string Name;

        public GraphNode(string name)
        {
            if (name.Length != 1) throw new ArgumentException("GraphNodes can only have a name of length one");
            Name = name;
            Connections = new List<GraphNode>();
        }
    }
}
