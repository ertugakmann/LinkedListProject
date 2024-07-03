namespace LinkedListProject
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

            
            Console.WriteLine("* * * * * * * * * * * * *");

            linkedList.DeleteLastNode();

            Console.WriteLine("Last Node will be deleted");
           
            linkedList.PrintList();
            linkedList.ListLength();
            linkedList.PrintHead();
            linkedList.PrintTail();

            Console.WriteLine("* * * * * * * * * * * * *");

            linkedList.DeleteFirstNode();

            Console.WriteLine("First Node will be deleted");

            linkedList.PrintList();
            linkedList.ListLength();
            linkedList.PrintHead();
            linkedList.PrintTail();

        }
    }
}
