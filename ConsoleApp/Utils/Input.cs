namespace ConsoleApp.Utils
{
    public class Input
    {
        public static int GetInt(string msg, string errorMsg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    if(int.TryParse(Console.ReadLine(), out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine(errorMsg);
                    }

                }catch (Exception)
                {

                }
            }
        }
    }
}
