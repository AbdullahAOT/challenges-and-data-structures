namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array 1 size");
            int arr1Size=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array 2 size");
            int arr2Size=Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[arr1Size];
            int[] arr2= new int[arr2Size];
            Console.WriteLine("Enter array 1 elements");
            for(int i=0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 elements");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The common elements are: ");
            int[] commonElementsArray = CommonElements(arr1, arr2);
            for (int i = 0;i < commonElementsArray.Length; i++)
            {
                Console.WriteLine(commonElementsArray[i]);
            }
        }
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonValuesList = new List<int>();
            for(int i = 0;i < arr1.Length;i++)
            {
                bool isCommon = false;
                for(int j = 0;j < arr2.Length;j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        isCommon = true;
                        break;
                    }
                }
                if(isCommon)
                {
                    commonValuesList.Add(arr1[i]);
                }
            }
            return commonValuesList.ToArray();
        }
    }
}