using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Simon_Says;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Simon simon = new Simon();
            Console.WriteLine(simon.Echo("Hello the sun shines"));
            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine("The value is : " + i);
                Console.WriteLine("Press any key");
                Console.ReadKey();
            }
        }
    }
}
