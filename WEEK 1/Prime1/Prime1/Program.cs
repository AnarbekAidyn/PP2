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
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            bool ok = false;

            for (int i = 2; i <= n; i++)
            {
                for(int j = 2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        ok = true;
                    }
                    if (ok == false)
                    {
                        Cnsole.WriteLine(i);
                    }
                    else ok = false;
                }
            }


            Console.ReadKey();

        }
    }
}
