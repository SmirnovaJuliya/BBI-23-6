using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lv 1 num 2
            //int y = Convert.ToInt32(Console.ReadLine());
            //int x = Convert.ToInt32(Console.ReadLine());
            //if (y >= 0 && (y + Math.Abs(x)) <= 1)
            //{
            //    Console.WriteLine("лежит");
            //}
            //else { Console.WriteLine("не лежит"); }


            //lv 1 num 5
            //// квадрат поместится в круге, если диагональ квадрата меньше или равна диаметру круга
            //double r = Convert.ToDouble(Console.ReadLine()); //площадь квадрата
            //double s = Convert.ToDouble(Console.ReadLine()); //площадь круга
            //double diam = 2 * Math.Sqrt(s / Math.PI);        //диаметр круга
            //double diag = Math.Sqrt(2 * s);                  //диагональ квадрата

            //if (diam >= diag)
            //{
            //    Console.WriteLine("поместится");
            //}
            //else { Console.WriteLine("не поместится"); }



            //lv 1 num 8
            //double y = 0;
            //double x = Convert.ToDouble(Console.ReadLine());
            //if (Math.Abs(x) >= 1)
            //{

            //    Console.WriteLine(y);
            //}
            //else if (Math.Abs(x) < 1)
            //{
            //    y = Math.Pow(x, 2) - 1;
            //    Console.WriteLine(y);
            //}



            //lv 2 num 2
            //Console.WriteLine("введите радиус");
            //int r = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите координату центра a");
            //int koorda = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите координату центра b");
            //int koordb = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите количество точек");
            //int kolvo = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //int res = 0;
            //while (i < kolvo)
            //{
            //    Console.WriteLine("введите координату x");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("введите координату y");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //    if (Math.Abs(x * x + y * y - r * r) <= 0.001)
            //    {
            //        res++;
            //    }

            //}
            //Console.WriteLine(res);



            //lv 2 num 5
            //Console.WriteLine("введите норматив");
            //double norma = Convert.ToDouble(Console.ReadLine());
            //double kolvo = 0;
            //for (int i = 0; i < 30; i++)
            //{
            //    Console.WriteLine("введите результат спортсмена");
            //    double res = Convert.ToDouble(Console.ReadLine());
            //    if (res >= norma)
            //    {
            //        kolvo++;
            //    }
            //}
            //Console.WriteLine(kolvo);

            //lv 2 num 8
            //Console.WriteLine("введите количество точек");
            //int kolvo = Convert.ToInt32(Console.ReadLine());
            //int num = 0;
            //double rast = 0;
            //double min = 1000000;
            //for (int i = 1; i < kolvo + 1; i++)
            //{
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    rast = Math.Sqrt(x * x + y * y);
            //    if (rast < min)
            //    {
            //        num = i;
            //        min = rast;
            //    }
            //}
            //Console.WriteLine(num);
            //Console.WriteLine(min);




































        }
    }
}      
