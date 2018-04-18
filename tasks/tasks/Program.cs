using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tasks
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for(int i=2; i*i<=n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\asus\Desktop\PP II\INPUT.txt");
            string s = sr.ReadLine();
            string[] arr = s.Split(' ');

            

            foreach(var num in arr)
            {
                int a = int.Parse(num);
                if (IsPrime(a))
                {
                    Console.WriteLine(a);
                }
            }

          

            Console.ReadKey();
        }
    }
}
