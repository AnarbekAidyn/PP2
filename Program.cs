using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ForMid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader str = new StreamReader(@"C:\Users\asus\Desktop\PP II\MidTerm/Input.txt");
            List<int> list = new List<int>();
            string s = str.ReadLine();
            string[] arr = s.Split(' ');
            foreach(var num in arr)
            {
                int x = int.Parse(num);
                list.Add(x);
            }
            list.Remove(list.Min());
            
            
            Console.WriteLine(list.Min());
            Console.ReadKey();

            
            StreamWriter sw = new StreamWriter("Output.txt");
            sw.Write(list.Min());

          //  str.Close();            
            sw.Close();

            Console.WriteLine(list.Min());
            Console.ReadKey();

             
        }
    }
}
