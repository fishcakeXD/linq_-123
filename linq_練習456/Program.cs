using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(',');
            int[] num = Array.ConvertAll(number,s => int.Parse(s));
            List<int> list = num.ToList();
            var num_1 =
                from p in list
                where p % 2 != 0
                select p;
            var num_2 =
                from p in list
                where p % 2 == 0
                select p;
            Console.Write("奇數為: ");
            foreach (var item in num_1)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            Console.Write("偶數為: ");
            foreach(var item in num_2)
            {
              Console.Write($"{item},");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
