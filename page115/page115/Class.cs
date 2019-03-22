using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page115
{
    class Class
    {
        public int oddNum { get; set; }

        public static int addOne(int num1, int num2 = 0)
        {
            int result = num1 + 1;
            int resultO = num2 + 1;
            return result;
        }
    }
}
