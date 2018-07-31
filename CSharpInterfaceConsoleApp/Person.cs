using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceConsoleApp
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }



        public virtual void SayName()
        {
            // It doesn't mention this in the exercise parameters, but I'm assuming it is supposed to be included.
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.ReadLine();
            // It doesn't mention this in the exercise parameters, but I'm assuming it is supposed to be included.
        }
    }
}
