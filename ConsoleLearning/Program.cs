using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 0;

            while (a < 100) {
                Console.WriteLine(a++);
            }

            string b = "" ;

            while (b != "exit") {
                Console.WriteLine("Input Exit for End Application");
                b = Console.ReadLine().ToLower();
            }

        }
    }
}
