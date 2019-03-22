using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int> { 123, 45, 78, 4, 11 };
                Console.WriteLine("Please enter a number:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    int quotient = number / divisor;
                    Console.WriteLine(quotient);
                }
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.ReadLine();
            }
        }
        

    }
}
