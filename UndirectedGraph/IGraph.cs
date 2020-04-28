using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    interface IGraph<N,L> : IEnumerable<N>
    {
        bool AddNode(N node);
        bool AddLink(N node1, N node2, L weight);
        void Clear();
        bool Contains(N node);
        bool Remove(N node);
        int Count { get; }
        bool IsEmpty { get;  }
        IEnumerable<N> Nodes { get; set; }
    }
}
