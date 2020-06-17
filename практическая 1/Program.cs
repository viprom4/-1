using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а ");
            int number_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число d ");
            int number_c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число c ");
            int number_d = int.Parse(Console.ReadLine());
            Console.WriteLine("Решение примера №4 = {0}", (Math.Log((2 * number_c), 10) + number_d - 52) / (number_a / 4 - 1));
            Console.ReadKey();
        }
    }
}
