using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int n =Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                if (n== 0) 
                {
                    Console.WriteLine(" Enter number is zero");
                }
                else
                {
                    Console.WriteLine(" Enter number  is positive");
                }

                {
                    Console.WriteLine("Enter  number is negative");
                }
            }
        }
    }
}
