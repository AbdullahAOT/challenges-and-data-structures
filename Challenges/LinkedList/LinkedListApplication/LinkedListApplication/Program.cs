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
            Console.WriteLine("//////////////");
            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();
            l1.AddToLinkedList(5);
            l2.AddToLinkedList(2);
            l1.AddToLinkedList(1);
            l2.AddToLinkedList(1);
            LinkedList l3 = l1.MergeSortedLists(l1, l2);
            l3.PrintLinkedList();
        }
    }
}
