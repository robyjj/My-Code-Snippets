using System;
using System.Linq;
using System.Collections.Generic;

namespace DSAlgo._04_Trees_and_Graphs
{
    /// <summary>
    /// Check if a route exists between 2 nodes in a graph
    /// Using BFS logic to implement this.
    /// </summary>
    public class GraphRoute
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
            //g.AddEdge(3, 3);
            int n1 = 0, n2 = 3;
            Console.WriteLine((CheckIfRouteExists(n1, n2) == true) ? "Exists" : "Not Exists");
            //n1 = 0; n2 = 2;
            //Console.WriteLine((CheckIfRouteExists(n1, n2) == true) ? "Exists" : "Not Exists");
            //n1 = 3; n2 = 1;
            //Console.WriteLine((CheckIfRouteExists(n1, n2) == true) ? "Exists" : "Not Exists");
            var result = GetAllPaths(1, 3);

            result.ForEach(r =>
            {
                r.ForEach(s =>
                {
                    Console.Write($"{s} ->");
                });
                Console.WriteLine();
            });
            Console.ReadLine();
        }

        private static bool CheckIfRouteExists(int n1, int n2)
        {
            Queue<int> items = new Queue<int>();
            bool[] visited = new bool[g.Vertices];
            items.Enqueue(n1);
            while (items.Count > 0)
            {
                int element = items.Dequeue();
                var adjList = g.adj[element];
                foreach(var item in adjList)
                {
                    if (item == n2)
                    {
                        return true;
                    }
                    if (!visited[item])
                    {
                        items.Enqueue(item);
                        visited[item] = true;                       
                    }                   
                }
            }
            return false;
        }

        private static List<List<int>> GetAllPaths(int n1, int n2)
        {
            Queue<List<int>> items = new Queue<List<int>>();
            List<List<int>> result = new List<List<int>>();
            bool[] visited = new bool[g.Vertices];

            items.Enqueue(new List<int>(new[] { n1 }));
            visited[n1] = true;
            while (items.Count > 0)
            {
                List<int> path = items.Dequeue();
                
                int lastNode = path[path.Count - 1];
                visited[lastNode] = true;
                if (lastNode == n2)
                {
                    result.Add(new List<int>(path));
                }
                else
                {
                    var neighbours = g.adj[lastNode];
                    foreach(var item in neighbours)
                    {
                        if (!visited[item])
                        {
                            var list = new List<int>(path);
                            list.Add(item);
                            items.Enqueue(list);
                        }
                    }
                }
            }
            return result;
        }
    }
}
