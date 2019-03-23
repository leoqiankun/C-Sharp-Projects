using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page114
{
    class Class
    {
        public int Int { get; set; }
        public double Double { get; set; }
        public string String { get; set; }

        public int method(int num)
        {
            int result = num * 2;
            return result;
        }

        public int method(double num)
        {
            double result = num / 2;
            return Convert.ToInt32(result);
        }

        public int method(string num)
        {
            int result = Convert.ToInt32(num) + 2;
            return result;
        }

    }

        
}
