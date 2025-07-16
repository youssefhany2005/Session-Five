using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace Session_Five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Looping | Iteration Statements
            //V-01
            #region for - foreach
            int[] Numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine($"Number 0 is {Numbers[0]}");
            //Console.WriteLine($"Number 1 is {Numbers[1]}");
            //Console.WriteLine($"Number 2 is {Numbers[2]}");
            //Console.WriteLine($"Number 3 is {Numbers[3]}");
            //Console.WriteLine($"Number 4 is {Numbers[4]}");


            //for(int i=0;i<Numbers.Length;i++)
            //{
            //if(int==2)
            //Continue
            //break;
            // Numbers[i] += 10;
            //    Console.WriteLine($"Number {i} is {Numbers[i]}");
            //}

            //foreach (int item in Numbers)
            //{
            //    //item += 10;
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            //V-02
            #region while - do while
            #region do-while
            //bool IsParse;
            //int number;

            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    IsParse = int.TryParse(Console.ReadLine(), out number);
            //} while (number % 2 == 1 || IsParse);

            //3%2=1 odd 
            //5%2=1 odd
            //7%2=1 odd
            //8%2=0 even
            #endregion
            #endregion
        }
    }
}
