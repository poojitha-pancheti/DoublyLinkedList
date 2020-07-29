using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;
            DoublyLinkedList list = new DoublyLinkedList();
            list.CreateList();
            while (true)
            {
                Console.WriteLine("1.Display the list");
                Console.WriteLine("2.Insert a node in the beginning of the list");
                Console.WriteLine("3.Insert in empty list");
                Console.WriteLine("4.Insert a node at the end of the list");
                Console.WriteLine("5.Insert a node after a specified node");
                Console.WriteLine("6.Insert a node before a specified node"); ;
                Console.WriteLine("7.Delete first node");
                Console.WriteLine("8.Delete last node");
                Console.WriteLine("9.Delete any node");
                Console.WriteLine("10.Reverse the list");
                Console.WriteLine("11.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 11)
                    break;
                switch (choice)
                {
                    case 1: 
                        list.DisplayList();
                        break;
                    case 2:
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break;
                    case 3:
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmpty(data);
                        break;
                    case 4:
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter the element to be inserted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element after which to inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 6:
                        Console.WriteLine("Enter the element to be inserted:");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element before which to inserted:");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                         
                         


                }



            }

        }
    }
}
