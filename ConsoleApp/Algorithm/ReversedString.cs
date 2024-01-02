namespace ConsoleApp.Algorithm
{
    public class ReversedString
    {
        private static bool IsReversedString(string firstString, string secondString)
        {
            if(firstString.Length != secondString.Length)
            {
                return false;
            }

            char[] chars = firstString.ToCharArray();

            Array.Reverse(chars);

            firstString = new string(chars);

            return string.Equals(firstString, secondString);
        }

        public static void HandCheckReversedString()
        {
            string firstString = "abcdef";
            string secondString = "fedcba";
            if(IsReversedString(firstString, secondString))
            {
                Console.WriteLine("Chuoi thu 2 la dao nguoc cua chuoi thu nhat");
            }
            else
            {
                Console.WriteLine("Chuoi thu 2 khong la dao nguoc cua chuoi thu nhat");

            }
        }
    }
}
