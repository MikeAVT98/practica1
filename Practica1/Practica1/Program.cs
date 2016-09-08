using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 100;
            while (x >= 1)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x - 1;
            }
            Console.ReadKey();
        }
    }
}
