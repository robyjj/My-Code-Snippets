using System;
using System.Collections.Generic;

namespace DSAlgo._04_Trees_and_Graphs
{
    public static class BreadFirstSearch
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
            int node = 2;
            BFSUtil(node, V);
            Console.ReadLine();
        }

        private static void BFSUtil(int node, int V)
        {
            bool[] visited = new bool[V];
            BFS_Iterative(node, visited);

        }

        private static void BFS_Iterative(int v, bool[] visited)
        {
            Queue<int> items = new Queue<int>();
            items.Enqueue(v);

            while (items.Count > 0)
            {
                v = items.Dequeue();
                visited[v] = true;
                Console.Write($"{v} ");

                var list = g.adj[v];
                foreach (var n in list)
                {                   
                    if (!visited[n])
                    {
                        items.Enqueue(n);
                    }
                }
            }
        }
    }
}
