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
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\asus\Desktop\PP II\INPUT.txt");
            string s = sr.ReadLine();
            string[]  arr= s.Split(' ');

            List<int> list = new List<int>();

            foreach(var num in arr)
            {
                int a = int.Parse(num);
                list.Add(a);
            }

            int max = list.Max();
            Console.WriteLine(max);
            Console.ReadKey();

        }
    }
}
