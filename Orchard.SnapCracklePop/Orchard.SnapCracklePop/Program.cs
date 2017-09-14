using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orchard.SnapCracklePop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to divisible by 3(SNAP), 5(CRACKLE), 15(POP) program");

            for (int i = 1; i < 100; i++)
            {
                if( i%15 == 0)
                {
                    Console.WriteLine("POP");
                }
                else if(i % 15 != 0 && i%5 == 0)
                {
                    Console.WriteLine("CRACKLE");
                }
                else if (i%15 != 0 && i%3 == 0)
                {
                    Console.WriteLine("SNAP");
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
