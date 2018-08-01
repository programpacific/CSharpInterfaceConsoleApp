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
        
            IQuittable quittable = new Employee();
            string quit = "Press enter to exit.";
            quittable.Quit(quit);
            Console.ReadLine();
            
        }
    }
}
