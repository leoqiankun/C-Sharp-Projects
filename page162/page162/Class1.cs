using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page162
{
    public class Class1
    {
        public Class1(string color) : this(color, 0)
        {

        }
        public Class1(string color, int number)
        {
            colors = color;
            size = number;
        }
        public string colors { get; set; }
        public int size { get; set; }
    }
}
