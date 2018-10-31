using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Конус
    {
        private double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        private double h;
        public double H
        {
            get { return h; }
            set { h = value; }
        }



        public double Sосн(double r, double h)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }
        public double Sбок(double r, double h)
        {
            return Math.PI * r * (Math.Pow(r, 2) + Math.Pow(h, 2));
        }
        public double V(double r, double h)
        {
            return (Math.PI * Math.Pow(r, 2) * h) / 3;
        }
    }
}
