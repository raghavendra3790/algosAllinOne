using System.Collections.Generic;
using System.IO;

namespace Graphs
{
    /// <summary>
    /// Interface that defines BFS and DFS
    /// </summary>
    public interface IGraphSearch
    {
        /// <summary>
        /// Is there a path from source to V?
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        bool HasPath(int v);

        /// <summary>
        /// Get the path from Source to V
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        List<int> Path(int v);
    }
}
