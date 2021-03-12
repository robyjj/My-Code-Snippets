using System.Collections.Generic;

namespace DSAlgo._04_Trees_and_Graphs
{
    /// <summary>
    /// Directed Graph using Adjaceny List
    /// </summary>
    public class Graph
    {
        //Number of Vertices
        public int Vertices { get; set; }
        public List<int>[] adj { get; set; }
        public Graph(int V)
        {
            Vertices = V;
            adj = new List<int>[Vertices];
            for(int i =0;i< Vertices; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int u ,int v)
        {
            adj[u].Add(v);           
        }
    }
}
