using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo._04_Trees_and_Graphs
{
    /// <summary>
    /// Check if 2 nodes are connected
    /// </summary>
    public class GraphConnection
    {
        static Graph g;
        public static void Run()
        {
            int V = 4;
            g = new Graph(V);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            int n1 = 0, n2 = 3;            
            Console.WriteLine((CheckIfNodesAreConnected(n1, n2) == true) ? "Connected" : "Not Connected");
            n1 = 0; n2 = 2;
            Console.WriteLine((CheckIfNodesAreConnected(n1, n2) == true) ? "Connected" : "Not Connected");
            n1 = 1; n2 = 3;
            Console.WriteLine((CheckIfNodesAreConnected(n1, n2) == true) ? "Connected" : "Not Connected");
            Console.ReadLine();
        }

        private static bool CheckIfNodesAreConnected(int n1, int n2)
        {
            var list = g.adj[n1];
            foreach(var i in list)
            {
                if(i == n2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
