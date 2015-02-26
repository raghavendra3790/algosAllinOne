using System;
using System.Collections.Generic;

namespace Graphs
{
    public class UndirectedGraph
    {
        /// <summary>
        /// Vetices counting starts from 1
        /// </summary>
        /// <param name="vertices"></param>
        public UndirectedGraph(int vertices)
        {
            Vertices = vertices;
            _adj = new List<int>[vertices+1];
            for (int i = 0; i <= vertices; i++)
            {
                _adj[i] = new List<int>();
            }
        }

        private List<int>[] _adj; 
        public int Vertices { get; private set; }

        public void AddEdge(int v, int w)
        {
            // Validate the vertices
            CheckRangeAndThrow(v);
            CheckRangeAndThrow(w);

            // Add mutual edges. Since it is undirected adding one edge makes both adjacent
            this._adj[v].Add(w);
            this._adj[w].Add(v);
        }

        public List<int> Adjacent(int v)
        {
            CheckRangeAndThrow(v);

            return this._adj[v];
        }

        private void CheckRangeAndThrow(int v)
        {
            if (v <= 0 || v > Vertices)
            {
                throw new ArgumentException("V");
            }
        }
    }
}
