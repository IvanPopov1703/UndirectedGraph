using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class ArrayGraph<N, L> : IGraph<N, L>
    {
        private const int maxCount = 4; //Максимально количество элементов в массиве
        private L[,] arrGraphArc = new L[maxCount, maxCount]; //Массив, с дугами графа
        private N[] arrVerticesGraph = new N[maxCount]; //Массив с вершинами графа
        private int count = 0; //Количество вершин в графе

        //Свойство получения количества вершин графа
        public int Count
        {
            get => this.count;
        }

        //Свойство проверки на пустоту
        public bool IsEmpty
        {
            get => Count == 0;
        }

        //-------------------Вспомогательные функции (Начало) -----------------//

        //Вспомогательная функция инициализации массива с ребрами
        private void InitializingArrArcWithDefault()
        {
            for (int i = 0; i < maxCount; i++)
                for (int j = 0; j < maxCount; j++)
                    arrGraphArc[i, j] = default;
        }

        //Вспомогательная функция инициализации массива с вершинами
        private void InitializingArrVerticesWithDefault()
        {
            for (int i = 0; i < maxCount; i++)
                arrVerticesGraph[i] = default;
        }

        //Функция для инициализации массивов
        private void InitializingArrayWithDefault()
        {
            InitializingArrArcWithDefault();
            InitializingArrVerticesWithDefault();
        }

        //Функция для определения индекса по имени
        private bool FindIndexByName(N name, out int index)
        {
            bool ok = false;
            index = 0;
            while (index < Count && !ok)
            {
                if (arrVerticesGraph[index].Equals(name))
                {
                    ok = true;
                }
                index++;
            }
            index--;
            return ok;
        }

        //Вспомогательная функция для соединения вершин
        private void HelpVertexJoin(int index1, int index2, L weight)
        {
            arrGraphArc[index1, index2] = weight;
            arrGraphArc[index2, index1] = weight;
        }

        //Вспомогательная функция для удаления элемента из массива вершин
        private void HelpDeleteElFromArrVertices(int index)
        {
            int i;
            if (index == (Count - 1))
            {
                arrVerticesGraph[index] = default;
            }
            else
            {
                for (i = index; i < Count - 1; i++)
                    arrVerticesGraph[i] = arrVerticesGraph[i + 1];
                arrVerticesGraph[i] = default;
            }
        }

        //Вспомогательная функция обнуления стоки массива, при удалении вершины
        private void ArrayZeroing(int i, int j = 0)
        {
            while (j < Count)
            {
                arrGraphArc[i, j] = default;
                j++;
            }   
        }

        //Вспомогательная функция для смещения по строкам, при удалении вершины
        private void HelpLineShift(int index)
        {
            int i, j;
            for (i = index; i < Count - 1; i++)
            {
                for (j = 0; j < Count; j++)
                {
                    arrGraphArc[i, j] = arrGraphArc[i + 1, j];
                }
            }
            ArrayZeroing(i); //Функция для обнуления строки
        }

        //Вспомогательная функция для смещения по столбцам, при удалении вершины
        private void HelpColumnShift(int index)
        {
            int i, j;
            for (i = 0; i < Count; i++)
            {
                for (j = index; j < Count - 1; j++)
                {
                    arrGraphArc[i, j] = arrGraphArc[i, j + 1];
                }
                arrGraphArc[i, Count - 1] = default;
            }
        }

        //Вспомогательная функция для удаления ребер из массива ребер
        private void HelpDeleteElFromArrArc(int index)
        {
            //Вспомогательная функция для смещения по строкам, при удалении вершины
            HelpLineShift(index);
            //Вспомогательная функция для смещения по столбцам, при удалении вершины
            HelpColumnShift(index);
            count--; //Уменьшение количества вершин
        }

        //Функция позволяющая получить данные из массива с вершинами
        public N[] GetValueFromArrVertices()
        {
            N[] arrTmp = new N[Count];
            for (int i = 0; i < Count; i++)
                arrTmp[i] = arrVerticesGraph[i];
            return arrTmp;
        }

        //Функция позволяющая получить данные из массива с вершинами
        public L[,] GetValueFromArrEdges()
        {
            L[,] arrTmp = new L[Count, Count];
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count; j++)
                {
                    arrTmp[i, j] = arrGraphArc[i, j];
                }
            }
            return arrTmp;
        }

        //-------------------Вспомогательные функции (Конец) -----------------//

        //Функция для добавления вершин
        public bool AddNode(N node)
        {
            if (Count < maxCount)
            {
                if (IsEmpty)
                {
                    //Инициализация массивов
                    InitializingArrayWithDefault(); 
                }

                arrVerticesGraph[Count] = node;
                count++;
                return true;
            }
            return false;
        }

        //Функция для соединения вершин
        public bool AddLink(N node1, N node2, L weight)
        {
            int index1, index2;
            //Получаем индекс первой вершины
            if (FindIndexByName(node1, out index1))
                if (FindIndexByName(node2, out index2)) //Получаем индекс второй вершины
                {
                    HelpVertexJoin(index1, index2, weight);//Установка свяхи между вершинами
                    return true;
                }
            return false;
        }

        //Функция для очистки массивов, которые содержат граф
        public void Clear()
        {
            //Инициализация массивов default value
            InitializingArrayWithDefault();
        }

        //Функция для проверки наличия вершины в графе
        public bool Contains(N node)
        {
            int i;
            return FindIndexByName(node, out i);
        }

        //Функция для удаления вершины
        public bool Remove(N node)
        {
            int index;
            if (FindIndexByName(node, out index))
            {
                HelpDeleteElFromArrVertices(index);
                HelpDeleteElFromArrArc(index);
                return true;
            }
            return false;
        }

        
        public IEnumerator<N> GetEnumerator()
        {
            int i = 0;
            while (i < Count)
            {
                yield return arrVerticesGraph[i];
                i++;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();



        /*public IEnumerable<N> Nodes
        {
            get => nodes;
            set
            {
                foreach (N n in value)
                {
                    this.AddNode(n);
                }
            }
        }*/

        //???????????????????????????? nodes
        public IEnumerable<N> Nodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}