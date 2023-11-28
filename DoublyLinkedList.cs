using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void InsertAtHead(T data)
        {
            var newNode = new DoublyLinkedListNode<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Prev = newNode;
                Head = newNode;
            }
        }

        public void InsertAtTail(T data)
        {
            var newNode = new DoublyLinkedListNode<T>(data);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
                Tail = newNode;
            }
        }

        public bool DeleteNode(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current.Prev != null)
                    {
                        current.Prev.Next = current.Next;
                    }
                    else
                    {
                        Head = current.Next;
                    }

                    if (current.Next != null)
                    {
                        current.Next.Prev = current.Prev;
                    }
                    else
                    {
                        Tail = current.Prev;
                    }

                    return true; // Node found and deleted
                }
                current = current.Next;
            }
            return false; // Node not found
        }

        public DoublyLinkedListNode<T> Find(T data)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return current;

                current = current.Next;
            }
            return null;
        }

        public void Traverse()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
