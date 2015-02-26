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
            UndirectedGraph g = UndirectedGraphSetUp.BuildGraph();
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
            UndirectedGraph g = UndirectedGraphSetUp.BuildGraph();
            DFS dfs = new DFS(g, 1);

            List<int> pathTo5 = dfs.Path(5);
            Assert.IsTrue(pathTo5.Contains(2));
            Assert.IsTrue(pathTo5.Contains(1));

            Assert.IsFalse(pathTo5.Contains(4));
        }
    }
}
