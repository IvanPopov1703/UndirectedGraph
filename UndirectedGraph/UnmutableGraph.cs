using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class UnmutableGraph<N, L> : IGraph<N, L>
    {
        public int Count => Count;

        public bool IsEmpty => IsEmpty;

        IGraph<N, L> graph;

        public UnmutableGraph(IGraph<N, L> graph) : base()
        {
            this.graph = graph;
        }


        //public N this[int index] { get => graph[index]; set => throw new GraphException("Изменить граф невозможно!"); }

        public bool AddLink(N node1, N node2, L weight)
        {
            throw new GraphException("Добавление ребра невозможно!");
        }

        public bool AddNode(N node)
        {
            throw new GraphException("Добавление вершины невозможно!");
        }

        public void Clear()
        {
            throw new GraphException("Очистка графа невозможна!");
        }

        public bool Contains(N node)
        {
            throw new NotImplementedException();//
        }

        public bool Remove(N node)
        {
            throw new GraphException("Удаление вершины невозможно!");
        }

        public IEnumerable<N> Nodes { get => graph; set => throw new GraphException("Попытка изменить неизменяемый граф"); }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        public IEnumerator<N> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /*IEnumerator<N> IEnumerable<N>.GetEnumerator()
        {
            int i = 0;
            while (i < Count)
            {
                yield return graph;
                i++;
            }
        }*/
    }
}
