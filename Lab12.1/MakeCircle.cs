using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    internal class MakeCircle
    {
        public static void LengthCircle(double r) // метод определения длины окружности
        {
            double l = 2 * Math.PI * r;
            Console.WriteLine(l);
        }
        public static void SCircle(double r) // метод определения площади круга
        {
            double s = Math.PI * r * r;
            Console.WriteLine(s);
        }
        public static void TCircle(double x0, double y0, double r, double x1, double y1) // метод определения принадлежности точки к кругу
        {
            if (r >= Math.Sqrt(Math.Pow(x1-x0,2)+ Math.Pow(y1-y0,2)))
            {
                Console.WriteLine("Точка находится в окружности");
            }
            else
            {
                Console.WriteLine("Точка за окружностью");
            }
        }
    }
}
