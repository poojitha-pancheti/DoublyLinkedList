using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        private Node start;
        public DoublyLinkedList()
        {
            start = null;

        }
        public void DisplayList()
        {
            Node p;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;    
            }
            p = start;
            Console.WriteLine("List is empty");
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
            Console.WriteLine();

        }
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }
        public void InsertInEmpty(int data)
        {
            Node temp = new Node(data);
            start = temp;
        } 
        public void InsertAtEnd(int data)
        {
            Node p = start;
            Node temp = new Node(data);
            while (p != null)
            {
                p = start;
                p.next = temp;
                temp.prev = p;
            }
        }
        public void InsertAfter(int data,int x)
        {
            Node temp = new Node(data);
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p == null)
                Console.WriteLine(x + "is not present in the list");
            else
            {
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                {
                    p.next.prev = temp;
                    p.next = temp;
                }
            }

        }
        public void InsertBefore(int data,int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (start.info == x)
            {
                Node temp = new Node(data);
                temp.next = start;
                start.prev = temp;
                start = temp;
                return;
            }
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                
                    break;
                    p = p.next;
                
            }
            if (p == null)
                Console.WriteLine(x + " is not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = p;
                p.prev = p;
            }

        }
        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the  number of nodes:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
                return;
            Console.WriteLine("Enter the elements to be inserted:");
                data = Convert.ToInt32(Console.ReadLine());

        }
    }
}
