using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page113
{
    class Program
    {
        static void Main(string[] args)
        {
            Class num1 = new Class();
            num1.primeNum = 5;
            Class num2 = new Class();
            num2.primeNum = 11;

            Class.test(num1:num1.primeNum, num2:num2.primeNum);
            
        }
    }
}
