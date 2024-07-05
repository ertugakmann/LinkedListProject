﻿namespace LinkedListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(12);
            linkedList.AppendList(13);
            linkedList.AppendList(14);
            linkedList.AppendList(15);
            linkedList.AppendList(16);
            linkedList.PrintList();
            linkedList.ListLength();
            linkedList.PrintHead();
            linkedList.PrintTail();

            // GetNode Method

            Node node = linkedList.GetNode(3);

            Console.WriteLine(node.data);
        }
    }
}
