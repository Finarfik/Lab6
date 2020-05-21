using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра х: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 2 * Math.Sin(x) + 3 * Math.Cos(x);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();

        }
    }
}
