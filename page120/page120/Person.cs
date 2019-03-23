using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page120
{
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }
    }
}
