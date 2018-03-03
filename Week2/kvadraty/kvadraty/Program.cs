using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            int minimum = 0;
            string str = File.ReadAllText(@"C:\Users\asus\Desktop\PP II\WEEK 1\MinMax\MinMax\Input.txt");
            string[] array = str.Split(' ');
            foreach (var num in array)
            {
                Int32.TryParse(num, out int x);

                if (maximum < x)
                {
                    maximum = x;
                }
                if (minimum > x)
                {
                    minimum = x;
                }

            }
            Console.WriteLine("the maximum number of this line is  " + maximum);
            Console.WriteLine("the minimum number of this line is  " + minimum);
            Console.ReadKey();

        }
    }
}


