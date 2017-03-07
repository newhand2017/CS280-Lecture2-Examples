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
            int? number_1 = null;
            int? number_2 = null;

            //---------------------------------------------
            Console.Write("請輸入第一個數字 : ");
            try
            {
                number_1 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("第一個數字輸入錯誤");
                Console.WriteLine("錯誤訊息 : \n" + e.ToString());

                return; //結束程式
            }

            //---------------------------------------------
            Console.Write("請輸入第二個數字 : ");
            try
            {
                number_2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("第二個數字輸入錯誤");
                Console.WriteLine("錯誤訊息 : \n" + e.ToString());

                return; //結束程式
            }

            //---------------------------------------------
            Console.WriteLine("{0} + {1} = {2}", number_1, number_2, number_1 + number_2);

            //---------------------------------------------
        }
    }
}