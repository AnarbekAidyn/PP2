using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        const double pi = Math.PI; 
        double radius;
        public void Area(double r)  /* Area S=2*PI*r */
        {
            this.radius = r;
            double A = pi * r * r;
            Console.WriteLine("area = " + A);
        }
        public void D(double r)
        {                                 /* r=d/2  */
            this.radius = r;
            Console.WriteLine("d = " + 2 * r);
        }
        public void L(double r)
        {
            this.radius = r;                       /*2*PI*r*/
            double C = 2 * pi * r;
            Console.WriteLine("L = " + C);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle s = new Circle();
            int x = Int32.Parse(Console.ReadLine());
            s.Area(x);

            s.L(x);

            s.D(x);
            Console.ReadKey();

        }
    }
}