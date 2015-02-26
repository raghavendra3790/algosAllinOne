using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graphs.Tests
{
    [TestClass]
    public class BFSTests
    {
        /// Build a graph which looks like
        ///             1
        ///         /       
        ///        2        3
        ///        /\       /\
        ///        4 5      6 7
        [TestMethod]
        public void TestHasPath()
        {
            UndirectedGraph g = UndirectedGraphSetUp.BuildGraph();
            BFS bfs = new BFS(g, 1);

            Assert.IsTrue(bfs.HasPath(2));
            Assert.IsTrue(bfs.HasPath(4));
            Assert.IsTrue(bfs.HasPath(5));

            Assert.IsFalse(bfs.HasPath(3));
            Assert.IsFalse(bfs.HasPath(6));
            Assert.IsFalse(bfs.HasPath(7));
        }

        [TestMethod]
        public void TestPathTo()
        {
            UndirectedGraph g = UndirectedGraphSetUp.BuildGraph();
            BFS bfs = new BFS(g, 1);

            List<int> path = bfs.Path(5);

            Assert.IsTrue(path.Contains(2));
            Assert.IsTrue(path.Contains(1));

            Assert.IsFalse(path.Contains(4));
        }
    }
}
