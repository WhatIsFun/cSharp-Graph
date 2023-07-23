using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Graph
{
    internal class CustomGraph
    {
        private Dictionary<String, List<String>> graph;
        public CustomGraph()
        {
            graph = new Dictionary<String, List<String>>();

        }
        public void AddVertex(String vertex)
        {
            if (!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<String>();
            }
        }

        public void AddEdge(String vertex1, String vertex2)
        {
            if (graph.ContainsKey(vertex1) && graph.ContainsKey(vertex2))
            {
                graph[vertex1].Add(vertex2);
                graph[vertex2].Add(vertex1);
            }
        }
        public List<String> Neighbor(String vertexes)
        {
            if (graph.ContainsKey(vertexes))
            {
                return graph[vertexes];
            }
            return null;

        }
        public Dictionary<String, List<String>> DisplayGraph()
        {
            return graph;
        }

        // BTS Graph Traversal.
        public void BreadthFirstSearch(string start)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue(start);

            HashSet<string> visited = new HashSet<string>();
            visited.Add(start);

            // if the queue is empty
            while (q.Count > 0)
            {
                string current = q.Dequeue();

                Console.WriteLine(current);

                foreach (string neighbor in graph[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        q.Enqueue(neighbor);
                    }
                }
            }
        }

        // DFS Graph Traversal..
        public void DFS(string vertex)
        {
            HashSet<string> visited = new HashSet<string>();
            Stack<string> stack = new Stack<string>();


            stack.Push(vertex);

            while (stack.Count != 0)
            {
                string currentvertex = stack.Pop();
                if (!visited.Contains(currentvertex))
                {
                    Console.WriteLine("next => " + vertex);
                    visited.Add(currentvertex);
                }


                foreach (string neighbor in graph[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {

                        stack.Push(neighbor);
                    }
                }
            }
        }
        public void DFSrecursive(string StartVertex)
        {
            HashSet<string> visited = new HashSet<string>();
            recursiveFun(StartVertex, visited);
        }

        private void recursiveFun(string currentVertex, HashSet<string> visited)
        {
            visited.Add(currentVertex);
            Console.WriteLine(currentVertex + " ");

            foreach (string neighbor in graph[currentVertex])
            {
                if (!visited.Contains(neighbor))
                {
                    recursiveFun(neighbor, visited);
                }
            }
        }
    }
    
}
