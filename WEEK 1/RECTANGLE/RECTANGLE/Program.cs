using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECTANGLE
{
    class Rectangle 
    {
        int height;
        int width;
        public void Perimeter(int a,int b)
        {
            this.height = b;
            this.width = a;
            double pmeter = a + a + b + b;
            Console.WriteLine("Perimeter of this rectangle is " + pmeter);

        }

        public void Area(int a_1, int b_1)
        {
            this.height = b_1;
            this.width = a_1;
            double A = a_1 * b_1;
            Console.WriteLine("Area of this rectangle is " + A);

        }

        static void Main(string[] args) {
            Console.WriteLine("Enter numbers: ");
        
            Rectangle s = new Rectangle();
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            s.Area(x, y);
            s.Perimeter(x, y);
            Console.ReadKey();  
        }
    }
}
