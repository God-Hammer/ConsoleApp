namespace ConsoleApp.Algorithm
{
    public class LargestNumber
    {

        //simple
        public static void FindLargestNumber()
        {
            int[] array = {1,8,5,4,9,5,2,45 };
            int i = 0;
            int largest = array[i];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > largest)
                {
                    largest = array[j];
                }
            }

            Console.WriteLine(largest);
        }

        //flex
        public static void FindLargestNumber2()
        {
            int[] array = { 1, 8, 5, 4, 9, 5, 2, 45 };
            
            if(array.Length < 0)
            {
                Console.WriteLine("Mang bi rong");
            }

            int largest = array[0];
            foreach (int i in array)
            {
                largest = Math.Max(largest, i);
            }
            Console.WriteLine(largest);

        }

        public static void CountNumberInArray()
        {
            int[] array = { 1, 8, 5, 4, 9, 5, 2, 45, 5, 2 };
            int target = 2;
            int count = 0;
            foreach(int number in array)
            {
                if (number.Equals(target))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
