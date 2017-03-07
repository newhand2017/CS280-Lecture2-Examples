using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //---------------------------------------------
            // Claim
            //---------------------------------------------
            int number_1 = 0;
            int number_2 = 0;

            //---------------------------------------------
            Console.Write("請輸入第一個數字 : ");
            try
            {
                number_1 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Write("請輸入第二個數字 : ");
            try
            {
                number_2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("{0} + {1} = {2}", number_1, number_2, number_1 + number_2);

            //---------------------------------------------
        }
    }
}