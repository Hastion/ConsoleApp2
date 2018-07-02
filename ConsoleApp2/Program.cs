using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "user";
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }
    }
}
