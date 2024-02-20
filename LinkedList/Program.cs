using System;
using System.Collections.Generic;

namespace LinkedList
{
    class LinkedList
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            foreach(int i in list)
                Console.WriteLine(i);
        }
    }
}