using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            string rate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            double weeklySalary1 = Convert.ToDouble(rate1) * Convert.ToDouble(hours1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            string rate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            double weeklySalary2 = Convert.ToDouble(rate2) * Convert.ToDouble(hours2);

            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine(weeklySalary1);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(weeklySalary2);

            bool result = weeklySalary1 > weeklySalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
