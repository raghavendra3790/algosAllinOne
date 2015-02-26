namespace Graphs.Tests
{
    internal class UndirectedGraphSetUp
    {
        /// Build a graph which looks like
        ///             1
        ///         /       
        ///        2        3
        ///        /\       /\
        ///        4 5      6 7
        public static UndirectedGraph BuildGraph()
        {
            UndirectedGraph ug = new UndirectedGraph(7);
            ug.AddEdge(1, 2);
            ug.AddEdge(2, 4);
            ug.AddEdge(2, 5);

            ug.AddEdge(3, 6);
            ug.AddEdge(3, 7);

            return ug;
        }
    }
}
