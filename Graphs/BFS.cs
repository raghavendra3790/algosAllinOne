using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class BFS : IGraphSearch
    {
        private int source;
        private int[] edgeTo;
        private bool[] marked;

        public BFS(UndirectedGraph g, int source)
        {
            this.source = source;
            edgeTo = new int[g.Vertices + 1];
            marked = new bool[g.Vertices + 1];
            bfs(g);
        }
        public bool HasPath(int v)
        {
            // Validate the vertex.

            return marked[v];
        }

        public List<int> Path(int v)
        {
            // Throw InvalidOperationException if the vertex is not marked.
            Stack<int> path = new Stack<int>();
            while (v != source)
            {
                path.Push(v);
                v = edgeTo[v];
            }

            path.Push(source);

            return path.ToList();
        }

        private void bfs(UndirectedGraph g)
        {
            Queue<int> q = new Queue<int>();
            
            q.Enqueue(source);
            marked[source] = true;

            while (q.Count != 0)
            {
                int current = q.Dequeue();

                foreach (int i in g.Adjacent(current))
                {
                    if (!marked[i])
                    {
                        marked[i] = true;
                        edgeTo[i] = current;
                        q.Enqueue(i);
                    }
                }
            }
        }
    }
}
