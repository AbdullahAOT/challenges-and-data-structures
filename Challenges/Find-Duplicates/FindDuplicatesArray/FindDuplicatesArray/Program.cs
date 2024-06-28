namespace FindDuplicatesArray
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of the array: ");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] duplicatesArray = FindDuplicatesArray(arr);
            Console.WriteLine("these are the duplicated values: ");
            for (int i = 0; i < duplicatesArray.Length; i++)
            {
                Console.WriteLine(duplicatesArray[i]);
            }
        }
        public static int[] FindDuplicatesArray(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > 1 && !AlreadyExist(arr[i], list))
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }
        public static bool AlreadyExist(int value, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
