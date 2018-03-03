using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rubezhka
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\asus\Desktop\PP II\rubezhka\input.txt");
            string s = sr.ReadLine();
            string[] arr = s.Split('\n');
            int n = int.Parse(arr[0]);
            
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine(arr[i]);
            }



            
            Console.ReadKey();
        }
    }
}
