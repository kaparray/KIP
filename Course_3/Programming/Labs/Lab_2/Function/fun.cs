using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func
{
    class fun
    {
        int b = 0;

        public double func(int x, double a)
        {
            return pfunc(x, a);
        }

        double pfunc(int x, double a)
        {
            double y = 0;
            if (x < 0)
            { 
                
                try
                {
                    y = x / Math.Log(x + a);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("Devide by zero");
                }
            }  
            else if (x >= 0)
            {
                y = Math.Pow(x, 2) * Math.Cos(x + a);
            }
            return y;
        }
    }
}
