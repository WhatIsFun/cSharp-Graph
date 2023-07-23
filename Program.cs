using System.Runtime.CompilerServices;

namespace cSharp_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomGraph graph = new CustomGraph();
            // Add Vertex
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");

            // Add Edge
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "D");
            graph.AddEdge("D", "A");
            graph.AddEdge("A", "C");


            // To display the graph
            Dictionary<string, List<string>> graphS = graph.DisplayGraph();
            foreach (var vertex in graphS)
            {
                Console.WriteLine("Vertex: " + vertex.Key);
                Console.WriteLine("Neighbors: " + string.Join(", ", vertex.Value));
                Console.WriteLine("_________________");
            }



            graph.BreadthFirstSearch("A");

            graph.DFS("A");

            graph.DFSrecursive("A");

        }
    }
}