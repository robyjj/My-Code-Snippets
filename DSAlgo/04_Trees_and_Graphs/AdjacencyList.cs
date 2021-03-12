using System;
using System.Collections.Generic;

namespace DSAlgo._04_Trees_and_Graphs
{
    public static class AdjacencyList
    {
        /*Graph representation using LinkedList*/
        public static void Run()
        {
            int V = 5;
            LinkedList<int>[] adj = new LinkedList<int>[V];
            for(int i=0;i<V;i++)
            {
                adj[i] = new LinkedList<int>();
            }

            AddEdge(adj, 0, 1);
            AddEdge(adj, 0, 4);
            AddEdge(adj, 1, 2);
            AddEdge(adj, 1, 3);
            AddEdge(adj, 1, 4);
            AddEdge(adj, 2, 3);
            AddEdge(adj, 3, 4);
            PrintGraph(adj);
            Console.ReadLine();
        }

        private static void AddEdge(LinkedList<int>[] adj,int u ,int v)
        {
            adj[u].AddLast(v);
            adj[v].AddLast(u);
        }
        private static void PrintGraph(LinkedList<int>[] adj)
        {
            for(int i =0; i<adj.Length; i++)
            {
                Console.WriteLine($"Adjaceny List of Vertex {i}");
                Console.Write("head");
                foreach (var item in adj[i])
                {
                    Console.Write($"-> {item}");
                }
                Console.WriteLine();
            }
        }
    }
}
