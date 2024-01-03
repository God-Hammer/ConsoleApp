using ConsoleApp.Algorithm;
using ConsoleApp.Utils;

internal class Program
{
    private static void Main(string[] args)
    {
        int input;
        do
        {
            input = Input.GetInt("Vui long chon: ", "Nhap lai");
            switch (input)
            {
                case 1:
                    //Console.WriteLine("Rows to columns And Columns to rows");
                    //RowsToConlumnsAndColumnsToRows.TransformData();

                    //Console.WriteLine("Find largest number");
                    //LargestNumber.FindLargestNumber2();

                    //Console.WriteLine("Prime number");
                    //IsPrimeNumber.HandleCheckPrime();

                    //Console.WriteLine("Reversed string");
                    //ReversedString.HandCheckReversedString();

                    //LargestNumber.CountNumberInArray();

                    Console.WriteLine("Sort");
                    Sort.HandleSort();

                    break;
                default:
                    //Console.ReadKey();
                    break;

            }
        } while (input > 0);
    }
}