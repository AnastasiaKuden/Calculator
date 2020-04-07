using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.MyCalculator
{
    public class DoSquare : ICalculate
    {
        public double DoMath(double tmp1, double tmp2 = 0)
        {
            return tmp1 * tmp1;
        }
    }
}
