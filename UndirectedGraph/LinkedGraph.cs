using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class LinkedGraph<N, L> : IGraph<N, L>
    {
        DoublyLinkedList<ObjectForList<N, L>> listGraph = new DoublyLinkedList<ObjectForList < N, L>>();

        private N fieldToInitN;
        private L fieldToInitL;

        public LinkedGraph() { }

        public LinkedGraph(N initN, L initL)
        {
            fieldToInitL = initL;
            fieldToInitN = initN;
        }

        //Количество элементов в списке
        public int Count
        {
            get => listGraph.Count;
        }

        //Проверка на пустоту списка
        public bool IsEmpty
        {
            get => Count == 0;
        }

        //Вспомогательная функция для сравнения
        private bool HelpFunctionToCompare()
        {

            return true;
        }

        //Вспомогательная функция для добавления
        private bool HelpAddLink(N node1, N node2, L weight)
        {
            if (!IsEmpty)
            {
                foreach (var obj in listGraph)
                {
                    if (obj.getBeginVertex().Equals(node1) && obj.getEndVertex().Equals(node2)
                        || obj.getBeginVertex().Equals(node2) && obj.getEndVertex().Equals(node1))
                    {
                        return false;
                    }
                    else
                    {
                        if (obj.getBeginVertex().Equals(node1) && obj.getEndVertex().Equals(fieldToInitN))
                        {
                            obj.setBeginVertex(node1);
                            obj.setEndVertex(node2);
                            obj.setWeight(weight);
                            return true;
                        }
                    }
                }
                ObjectForList<N, L> objectForList = new ObjectForList<N, L>(node1, node2, weight);
                listGraph.Add(objectForList);
                return true;
            }
            return false;
        }
        
        public bool AddLink(N node1, N node2, L weight)
        {
            return HelpAddLink(node1, node2, weight);
        }

        //Добавление элемента в список
        public bool AddNode(N node)
        {
            ObjectForList<N, L> objectForList = new ObjectForList<N, L>(node, fieldToInitN, fieldToInitL);
            listGraph.Add(objectForList);
            return true;
        }

        //Очистка графа
        public void Clear()
        {
            listGraph.Clear();
        }

        //Проверка наличия вершины в графе
        public bool Contains(N node)
        {
            if (!IsEmpty)
            {
                foreach (var obj in listGraph)
                {
                    if (obj.getBeginVertex().Equals(node) || obj.getEndVertex().Equals(node))
                        return true;
                } 
            }
            return false;
        }

        public bool Remove(N node)
        {
            if (!IsEmpty)
            {
                foreach (var item in listGraph)
                {
                    if (item.getBeginVertex().Equals(node))
                    {
                        //if (item.getEndVertex().Equals(fieldToInitN))
                        //    listGraph.Remove(item);
                        //else
                        //    item.setBeginVertex(item.getEndVertex());
                        listGraph.Remove(item);
                    }
                    else
                    {
                        if (item.getEndVertex().Equals(node))
                        {
                            if (item.getBeginVertex().Equals(fieldToInitN))
                                listGraph.Remove(item);
                            else
                                item.setEndVertex(fieldToInitN);
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public IEnumerator<N> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<N> Nodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}




/*/Вспомогательная функция для добавления
        private bool HelpAddLink(N node1, N node2, L weight)
        {
            if (!IsEmpty)
            {
                foreach (var obj in listGraph)
                {
                    if (obj.getBeginVertex().Equals(node1) && obj.getEndVertex().Equals(node2)
                        || obj.getBeginVertex().Equals(node2) && obj.getEndVertex().Equals(node1))
                    {
                        return false;
                    }
                    else
                    {
                        if (obj.getBeginVertex().Equals(node1) && obj.getEndVertex().Equals(fieldToInitN)
                            || obj.getBeginVertex().Equals(node2) && obj.getEndVertex().Equals(fieldToInitN))
                        {
                            obj.setBeginVertex(node1);
                            obj.setEndVertex(node2);
                            obj.setWeight(weight);
                            return true;
                        }
                    }
                }
                ObjectForList<N, L> objectForList = new ObjectForList<N, L>(node1, node2, weight);
                listGraph.Add(objectForList);
                return true; 
            }
            return false;
        }*/
