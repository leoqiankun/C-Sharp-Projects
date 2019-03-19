using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page92
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Please enter the package width:");
            float width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            float length = Convert.ToSingle(Console.ReadLine());
            float dimensions = width + height + length;
            
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            float quote = dimensions * weight / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(quote, 2));
            Console.WriteLine("Thank you.");
            Console.ReadLine();
            
        }
    }
}
