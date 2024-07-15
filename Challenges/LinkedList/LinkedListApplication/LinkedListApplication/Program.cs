namespace LinkedListApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddToLinkedList(5);
            list.AddToLinkedList(5);
            list.AddToLinkedList(5);
            list.AddToLinkedList(2);
            list.AddToLinkedList(1);
            list.PrintLinkedList();
            Console.WriteLine("//////////////");
            list.LinkedListIncludes(4);
            list.LinkedListRemove(1);
            list.PrintLinkedList();
            Console.WriteLine("//////////////");
            list.RemoveDuplicates();
            list.PrintLinkedList();
        }
    }
}
