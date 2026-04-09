using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HF03
{
    public class Diag
    {
        private double[] x;
        public class NegativeArraySizeException : Exception{ };
        public class NotSameSizedDiagsException : Exception { };

        public Diag(int n)
        {
            if(n < 0)
            {
                throw new NegativeArraySizeException();
            }
            x = new double[n];
        }
        public double Get(int i, int j)
        {
            if ((i < 0 || i > x.Count() - 1) || (j < 0 || j > x.Count() - 1))
            {
                throw new IndexOutOfRangeException();
            }
            if(i == j)
            {
                return x[i];
            }
           
            return 0.0;
        }

        public void Set(int i, int j, double e)
        {
            if ((i < 0 || i > x.Count() - 1) || (i < 0 || i > x.Count() - 1))
            {
                throw new IndexOutOfRangeException();
            }
            if (i == j)
            {
                x[i] = e;
            }else if(e != 0.0){
                throw new IndexOutOfRangeException();
            }
        }

        public static Diag operator +(Diag a, Diag b)
        {
            if (a.x.Count() != b.x.Count())
            {
                throw new NotSameSizedDiagsException();
            }
            Diag c = new Diag(a.x.Count());
            for (int i = 0; i < c.x.Count(); i++)
            {
                c.x[i] = a.x[i] + b.x[i];
            }
            return c;
        }

        public static Diag operator *(Diag a, Diag b)
        {
            if (a.x.Count() != b.x.Count())
            {
                throw new NotSameSizedDiagsException();
            }
            Diag c = new Diag(a.x.Count());
            for (int i = 0; i < c.x.Count(); i++)
            {
                c.x[i] = a.x[i] * b.x[i];
            }
            return c;
        }
    }
}
