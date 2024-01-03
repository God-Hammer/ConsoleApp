namespace ConsoleApp.Algorithm
{
    public class Sort
    {

        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        private static void InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        private static void BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j-1])
                    {
                        Swap(array, j, j-1);
                    }
                }
            }
        }

        public static void HandleSort()
        {
            int[] array = { 1, 5, 7, 8, 2, 12, 51, 7, 9, 10 };
            BubbleSort(array);
            Console.WriteLine($"{string.Join(" | ", array)}");
        }
    }
}
