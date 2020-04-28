using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    //Данный класс представляет объект, который будет добавляться в список,
    //содержащий граф

    class ObjectForList<N, L>
    {
        private N beginVertex; //Вершина графа
        private N endVertex; //Ребро графа
        private L weight; //Вес вершины

        public ObjectForList() { }

        public ObjectForList(N beginVertex, N endVertex, L weight)
        {
            this.beginVertex = beginVertex;
            this.endVertex = endVertex;
            this.weight = weight;
        }
        
        public N getBeginVertex()
        {
            return beginVertex;
        }

        public void setBeginVertex(N beginVertex)
        {
            this.beginVertex = beginVertex;
        }

        public N getEndVertex()
        {
            return endVertex;
        }

        public void setEndVertex(N endVertex)
        {
            this.endVertex = endVertex;
        }

        public L getWeight()
        {
            return weight;
        }

        public void setWeight(L weight)
        {
            this.weight = weight;
        }
    }
}
