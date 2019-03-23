using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page117
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine("Please enter an odd number:");
            number.Odd = Convert.ToInt32(Console.ReadLine());
            number.Divide(number.Odd, out int result);
            Console.WriteLine(number.Odd + " divided by 2 is " + result + ".");
            Console.ReadLine();
            
        }
    }
}
