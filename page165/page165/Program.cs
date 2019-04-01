using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page165
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                int year = DateTime.Now.Year - age;
                Console.WriteLine("You were born in {0}.", year);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Age can not be zero or under zero!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("The age you entered is not valid!");
                Console.ReadLine();
            }
            
        }
    }
}
