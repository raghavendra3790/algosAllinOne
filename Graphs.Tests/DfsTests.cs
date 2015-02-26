using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Graphs;

namespace Graphs.Tests
{
    [TestClass]
    public class DfsTests
    {
        [TestMethod]
        public void TestDFSHasPathSuccess()
        {
            UndirectedGraph g = BuildGraph();
            DFS dfs = new DFS(g, 1);
            Assert.IsTrue(dfs.HasPath(2));
            Assert.IsTrue(dfs.HasPath(4));
            Assert.IsTrue(dfs.HasPath(5));

            Assert.IsFalse(dfs.HasPath(3));
            Assert.IsFalse(dfs.HasPath(6));
            Assert.IsFalse(dfs.HasPath(7));
        }

        [TestMethod]
        public void TestDFSPathSuccess()
        {
            UndirectedGraph g = BuildGraph();
            DFS dfs = new DFS(g, 1);

            List<int> pathTo5 = dfs.Path(5);
            Assert.IsTrue(pathTo5.Contains(2));
            Assert.IsTrue(pathTo5.Contains(1));

            Assert.IsFalse(pathTo5.Contains(4));
        }

        /// Build a graph which looks like
        ///             1
        ///         /       
        ///        2        3
        ///        /\       /\
        ///        4 5      6 7
        private UndirectedGraph BuildGraph()
        {
            Graphs.UndirectedGraph ug = new UndirectedGraph(7);
            ug.AddEdge(1, 2);
            ug.AddEdge(2, 4);
            ug.AddEdge(2, 5);

            ug.AddEdge(3, 6);
            ug.AddEdge(3, 7);

            return ug;
        }
    }
}
