using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kocka
{
    class NegyszogClass
    {
        private double elsooldal, masodikoldal, kerulet, terulet;
        public NegyszogClass(double a, double b)
        {
            this.elsooldal = a;
            this.masodikoldal = b;
        }
        public void setKerulet(double a,double b)
        {
            this.terulet = 2*(a + b);
        }
        public void setTerulet(double a, double b)
        {
            this.terulet = a * b;
        }
        public double getKerulet()
        {
            return this.kerulet;
        }
        public double getTerulet()
        {
            return this.terulet;
        }
        public double getOldal()
        {
            return this.elsooldal;
        }

        public double getOldal2()
        {
            return this.masodikoldal;
        }
    }
}
