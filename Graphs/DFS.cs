using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class DFS : IGraphSearch
    {
        private int source;
        private bool[] marked;
        private int[] edgeTo;
        public DFS(UndirectedGraph graph, int source)
        {
            this.source = source;
            this.marked = new bool[graph.Vertices+1];
            this.edgeTo = new int[graph.Vertices+1];
            dfs(graph, this.source);
        }

        public bool HasPath(int v)
        {
            return this.marked[v];
        }

        public List<int> Path(int v)
        {
            if(!marked[v])
                throw new Exception("Not in the path");
            Stack<int> path = new Stack<int>();
            path.Push(source);

            while (v != source)
            {
                path.Push(v);
                v = edgeTo[v];
            }

            return path.ToList();
        }

        private void dfs(UndirectedGraph g, int s)
        {
            marked[s] = true;

            foreach (int i in g.Adjacent(s))
            {
                if (!marked[i])
                {
                    dfs(g, i);
                    edgeTo[i] = s;
                }
            }
        }
    }
}
