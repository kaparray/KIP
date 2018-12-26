using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, rez;
            Console.Write("Введите значение a: ");
            a = double.Parse(Console.ReadLine());
            for (int x = -20; x <= 20; x++)
            {
                fun f = new fun();
                rez = f.func(x, a);
                
                if (double.IsNegativeInfinity(rez))
                    Console.WriteLine("Функцию x = {0} вычислить нельзя!", x);
                else
                    Console.WriteLine("x = {0}   y = {0:f3}", x, rez);
            }
            Console.ReadLine();
        }
    }
}
