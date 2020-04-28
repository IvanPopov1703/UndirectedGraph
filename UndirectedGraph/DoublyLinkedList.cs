using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    //Сам класс списка
    class DoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyNode<T> head; //голова
        DoublyNode<T> tail; //хвост
        int count; //количество элементов в списке

        //Количество элементов
        public int Count
        {
            get => count;
            set => count++;
        } 
        public bool IsEmpty { get => count == 0; } //Проверка ну пустоту

        //Добавление элемента
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        //Добавление элемента в начало
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> tmpNode = head;
            node.Next = tmpNode;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                tmpNode.Previous = node;
            }
            count++;
        }

        //Удаление
        public bool Remove(T data)
        {
            DoublyNode<T> current = head;
            //Поиск удаляемого узла
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                //если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else //Если последний, переустанавливаем tail
                {
                    tail = current.Previous;
                }

                //если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else //если первый, переустанавливаем head
                {
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        //Очистка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //Проверка наличия элементов
        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        //Для прохода вперед
        public IEnumerator<T> GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        //Для прохода назад
        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
