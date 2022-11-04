using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("асф");

            double a, b, c, x, result;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());

            result = (b - a) / (2 * b + c) * (a - c) * Math.Cos(x);

            Console.WriteLine("Рузлтат= " + result);
            Console.WriteLine("Натиснете произволен клавиш. . .");
        }
    }
}
