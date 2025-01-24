using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<T>
    {
        private Node<T> head;
        public void Add(T data)
        {
            var newNode = new Node<T>(data);

            if (head == null)
                head = newNode;
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Display()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
