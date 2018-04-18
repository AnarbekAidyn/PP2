using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\asus\Desktop\PP II\MidTerm\input.txt");
            string s = sr.ReadToEnd();
            string[] arr = s.Split('\n');

            int n = arr.Length;
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey(); 
        }
    }
}
