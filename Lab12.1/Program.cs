using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            MakeCircle.LengthCircle(r);
            MakeCircle.SCircle(r);
            MakeCircle.TCircle(r,x0,x1,y0,y1);
            Console.ReadKey();
        }
    }
}
