using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string name = strArray[0];
            string revers = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                revers += name[i];
            }
            if (name == revers)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
            Console.ReadKey();
        }
    }
}
