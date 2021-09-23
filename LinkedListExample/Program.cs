using System;
using System.Collections.Generic;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a linked list
            var names = new LinkedList<string>();

            //add element to linked list
            names.AddLast("Mishu");
            names.AddFirst("Shihab");
            names.AddLast("Rayhan");


            //Iterate Linked list
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            //create a new node
            LinkedListNode<string> node = names.Find("Mishu");
            names.AddBefore(node, "Moshrefa");
            names.AddAfter(node, "Love");

            //print show message
            Console.WriteLine("After new element added: ");

            //Iterate after new element added
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
