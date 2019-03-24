using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page124
{
    public abstract class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
