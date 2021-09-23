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
        }
    }
}
