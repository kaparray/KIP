using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Сфера
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public double S(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }
        public double V(double r)
        {
            return (4 * Math.PI * Math.Pow(r, 3)) / 3;

        }
    }
}
