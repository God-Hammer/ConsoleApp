namespace ConsoleApp.Algorithm
{
    public class IsPrimeNumber
    {
        private static bool IsPrime(int number)
        {
            if(number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void HandleCheckPrime()
        {
            int number = 17;

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{number} khong la so nguyen to.");

            }
        }
    }
}
