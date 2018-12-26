using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Класс
    {
        public double Y { get; private set; }
        public Класс(double x, double a)
        {
            Y = Calc(x, a);
        }

        private double Calc(double x, double a)
        {
            if (x < 0)
                return x / Math.Log(x + a);
            else
                return x * x * Math.Cos(x - a);
        }

    }
}
