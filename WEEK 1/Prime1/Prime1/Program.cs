using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
           

            int j;
            bool ok = false;

            for(int i=2; i<=number; i++)
            {
                for(j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        ok = true;
                    }
                    
                    
                }
                if (ok == false)
                {
                    Console.WriteLine(j);
                }

                else ok = false;
            }


            Console.ReadKey();

        }
    }
}
