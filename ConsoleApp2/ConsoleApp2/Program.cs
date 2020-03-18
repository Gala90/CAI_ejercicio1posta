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
            int i;
            
            for (i = 1; i < 103; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {  

                if (i % 3 == 0)
                {
                    Console.WriteLine(i + " Foo");
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine(i + " Bar");
                }

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine(i + "FooBar");
                }
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
    }
}
