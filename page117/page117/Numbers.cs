using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page117
{
    class Numbers
    {
        public int Odd { get; set; }
        public int Even { get; set; }

        public void Divide(int num1, out int result)
        {
            int num = num1 / 2;
            result = num;
        }

        public void Divide(int num1, out int result, out int result2)
        {
            int num = num1 / 2;
            result = num;
            result2 = num + 2;
        }



    }
}
