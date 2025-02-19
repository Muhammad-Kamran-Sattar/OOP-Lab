using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cal
{
    
    public class Calculator
    {
        public float Num1;
        public float Num2;
        public float Total;
        public Calculator() { }
        public Calculator(float num1, float num2)
        {
         Num1=num1;
         Num2=num2;
        }
          public float add()
          {
            Total = Num1 + Num2;
            return Total;
          }
        public float sub()
        {
            Total = Num1 - Num2;
            return Total;
        }
        public float mul()
        {
            Total = Num1 * Num2;
            return Total;
        }
        public float div()
        {
            Total = Num1 / Num2;
            return Total;
        }


    }
}
