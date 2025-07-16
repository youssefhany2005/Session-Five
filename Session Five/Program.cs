using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            // V-03
            #region while

            //Console.WriteLine("Enter a number");
            //bool IsParse = int.TryParse(Console.ReadLine(), out int number);
            //2-10
            //5-10
            //12

            //if (IsParse)
            //{
            //    while (number <= 10) /* IsParse == true*/
            //    {
            //        Console.WriteLine(number);
            //        number++;
            //    }
            //}
            #endregion
            #endregion
            #endregion

            #region String
            //V-04
            #region Example 01
            //string Name;
            //Name = new string("Route");//10 Bytes

            //Console.WriteLine($"Name =  {Name}");
            //Console.WriteLine($"Hashcode =  {Name.GetHashCode()}");

            //string Name02 = "Route";

            //Console.WriteLine($"Name =  {Name02}");
            //Console.WriteLine($"Hashcode =  {Name02.GetHashCode()}");
            //
            #endregion

            #region Example 02
            //string name01="Amr";
            //string name02="May";

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"HashCode of name01 = {name01.GetHashCode()}");

            //Console.WriteLine($"name02 = {name02}");
            //Console.WriteLine($"HashCode of name02 = {name02.GetHashCode()}");

            //name02 = name01;
            //Console.WriteLine("After Assign");

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"HashCode of name01 = {name01.GetHashCode()}");

            //Console.WriteLine($"name02 = {name02}");
            //Console.WriteLine($"HashCode of name02 = {name02.GetHashCode()}");

            //name01 = "Omar";
            //Console.WriteLine("After Change value of name01");

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"HashCode of name01 = {name01.GetHashCode()}");

            //Console.WriteLine($"name02 = {name02}");
            //Console.WriteLine($"HashCode of name02 = {name02.GetHashCode()}");

            #endregion

            #region Example 03
            //string message = "Hello";

            //Console.WriteLine($"Message = {message}");
            //Console.WriteLine($"HashCode of message = {message.GetHashCode()}");

            //message += "Route";
            //Console.WriteLine("After Change");

            //Console.WriteLine($"Message = {message}");  
            //Console.WriteLine($"HashCode of message = {message.GetHashCode()}");
            #endregion

            //V-05
            #region String Methods
            //string message = "Hello Route"; //size => 17
            //Console.WriteLine(message.Length); // 17
            //Console.WriteLine(message.ToUpper()); // 17
            //Console.WriteLine(message.ToLower()); // 17
            //Console.WriteLine(message.Trim()); // 17
            //Console.WriteLine(message.TrimEnd()); // 17
            //Console.WriteLine(message.TrimStart()); // 17
            //Console.WriteLine(message.Substring(4,5)); // 17
            //Console.WriteLine(message.Replace('e','T')); // 17
            //Console.WriteLine(message.Contains('f')); // 17
            #endregion

            #endregion
        }
    }
}
