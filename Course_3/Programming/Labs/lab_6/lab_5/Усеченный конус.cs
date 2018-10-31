using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    class Усеченный_конус
    {
        private double rnij;
        public double R
        {
            get { return rnij; }
            set { rnij = value; }
        }
        private double r2;
        public double R2
        {
            get { return r2; }
            set { r2 = value; }
        }

        private double h;
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public double Sниж(double rnij)
        {
            return Math.PI * Math.Pow(rnij, 2);
        }
        public double Sбок(double rnij, double r2)
        {
            return Math.PI * (rnij + r2) * (Math.Pow(rnij, 2) + Math.Pow(h, 2));
        }
        public double Sверхн(double r2)
        {
            return Math.PI * Math.Pow(r2, 2);
        }
        public double V(double rnij, double r2, double h)
        {
            return (h * (Math.Pow(r2, 2) + r2 * rnij + Math.Pow(rnij, 2))) / 3;
        }
    }
}
