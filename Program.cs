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

            Console.WriteLine("new node adding...");

            Console.WriteLine("Please enter a value");

            string inputValue = Console.ReadLine();

            int value = int.Parse(inputValue);

            linkedList.AddFirst(value);

            linkedList.PrintList();
        }
    }
}
