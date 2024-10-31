namespace LinkedListApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.AddToLinkedList(5);
            //list.AddToLinkedList(5);
            //list.AddToLinkedList(5);
            //list.AddToLinkedList(2);
            //list.AddToLinkedList(1);
            //list.PrintLinkedList();
            //Console.WriteLine("//////////////");
            //list.LinkedListIncludes(4);
            //list.LinkedListRemove(1);
            //list.PrintLinkedList();
            //Console.WriteLine("//////////////");
            //list.RemoveDuplicates();
            //list.PrintLinkedList();
            LinkedList list = new LinkedList();
            list.AddToLinkedList(1);
            list.AddToLinkedList(2);
            list.AddToLinkedList(3);
            list.AddToLinkedList(4);
            list.AddToLinkedList(5);
            list.AddToLinkedList(6);

            Console.WriteLine("Original List:");
            list.PrintLinkedList();

            list.RotateLeft(2);
            Console.WriteLine("Rotated List:");
            list.PrintLinkedList();
        }
    }
}
