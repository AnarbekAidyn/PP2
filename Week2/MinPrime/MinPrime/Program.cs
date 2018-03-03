using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinPrime
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            if (n == 1) 
                return false;
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\asus\Desktop\PP II\Week2\MinPrime\MinPrime.txt");
            string line = File.ReadAllText(@"C:\Users\asus\Desktop\PP II\Week2\MinMax\MinMax\Input.txt");
            string[] arr = line.Split(' ');
           

            var list = new List<int>();

            foreach (string num in arr)
            {
                int a = Int32.Parse(num);
                if (IsPrime(a))
                {
                    list.Add(a);


                }


            }
            int minimumprime = list.Min();
            sw.Write(minimumprime);
            sw.Close();

        }


    }
}