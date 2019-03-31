using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date and timme: " + DateTime.Now + ".");
            Console.WriteLine("Please enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Now;
            dt = dt.AddHours(number);
            Console.WriteLine("In {0} hours, the date and time will be {1}", number, dt);           
            Console.ReadLine();
        }
    }
}
