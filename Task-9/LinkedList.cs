using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class LinkedList : IEnumerable<Node>
    {
        Node head; // головной/первый элемент
        Node tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void Add(Tariff data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        // удаление элемента
        public bool Remove(string data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.NameTarrif1.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(String data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.NameTarrif1.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public string SearchToPrint(String data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.NameTarrif1.Equals(data))
                    return current.Data.PrintInfo();
                current = current.Next;
            }
            return "Not found";
        }
        // добвление в начало
        public void AppendFirst(Tariff data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator<Node> IEnumerable<Node>.GetEnumerator()
        {
            return ((IEnumerable<Node>)this).GetEnumerator();
        }
    }
    public class Node
    {
        public Node(Tariff data)
        {
            Data = data;
        }
        public Tariff Data { get; set; }
        public Node Next { get; set; }
    }
}
