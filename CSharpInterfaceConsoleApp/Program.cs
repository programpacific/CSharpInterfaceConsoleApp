using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable stop = new Employee();
            string quit = "Press enter to exit.";
            stop.Quit(quit);
            Console.ReadLine();
        }
    }
}
