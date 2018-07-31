using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceConsoleApp
{
    public class Employee : Person, IQuittable
    {
        public void Quit(string quit)
        {
            Console.WriteLine("Hello everybody!");
        }

        public override void SayName()
        {
            base.SayName();
        }

    }


}