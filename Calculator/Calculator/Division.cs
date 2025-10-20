using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Division
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Nämnaren (b) får inte vara 0.");
            }

            return a / b;
        }
    }
}

// venu