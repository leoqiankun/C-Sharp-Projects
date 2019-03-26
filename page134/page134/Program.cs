using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page134
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week:");

                string today = Console.ReadLine();

                Days day = (Days)Enum.Parse(typeof(Days), today, true);

                if (day == Days.Tuesday)
                {
                    Console.WriteLine("That's correct!");
                }
                else
                {
                    Console.WriteLine("That's incorrect!");
                }

                Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
            
        }
    }
}
