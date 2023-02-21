using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace linq_練習123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] number = Console.ReadLine().Split(',');
            List<string> list = number.ToList();
            list.Reverse();
            
            foreach(var item in list)
            {               
                Console.Write(item+",");   
            }
            Console.ReadLine();


        }
    }
}
