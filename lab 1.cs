using System;
using System.Reflection.Metadata;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lv 1 num 1
            //double res = 0;
            //for (int i = 2; i < 36;)
            //{
            //    res += i;
            //    i += 3;
            //}
            //Console.WriteLine(res);

            //// lv 1 num 2
            //double sum = 0;
            //for (double i = 1; i <= 10; i += 1)
            //    sum = sum + (1 / i);
            //Console.WriteLine(sum);

            //// lv 1 num 3
            //double sum = 0;
            //for (double i = 1; i <= 113; i += 2)
            //{
            //    sum += (i + 1) / (i + 2);
            //}
            //Console.WriteLine(sum);

            //// lv 1 num 4
            //double sum = 0;
            //int x = 10;
            //for (int i = 0; i <= 8; i += 1)
            //{
            //    sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0);
            //}
            //Console.WriteLine(sum);

            //// lv 1 num 5
            //int p = 1;
            //int sum = 0;
            //for (int h = 0; h <= 9; h++)
            //{
            //    int ph = p + h;
            //    sum = (int)(sum + Math.Pow(ph, 2));
            //}
            //Console.WriteLine(sum);

            //// lv 1 num 6
            //double number = 0;
            //for (double i = -4; i <= 4; i += 0.5)
            //{
            //    number = (Math.Pow(0.5 * i, 2) - 7 * i);
            //    Console.WriteLine($"{number} {i}");

            //// lv 1 num 7
            //int proizv = 1;
            //for (int i = 1; i <= 6; i++)
            //{
            //    proizv = proizv * i;
            //}
            //Console.WriteLine(proizv);

            //// lv 1 num 8
            //int sum = 0;
            //int fact1 = 1;
            //for (int i = 1; i <= 6; i++)
            //{
            //    fact1 = fact1 * i;
            //    sum += fact1;
            //}
            //Console.WriteLine(sum);

            //// lv 1 num 9
            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;

            //    return n * Factorial(n - 1);
            //}

            //int sum = 0;
            //int number = 0;

            //for (int i = 1; i <= 6; i++)
            //{
            //    number = (int)(Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i));
            //    sum += number;
            //}
            //Console.WriteLine(number);

            //// lv 1 num 10
            //int number = 1;
            //for (int i = 1; i <= 7; i++)
            //{
            //    number *= 3;
            //}
            //Console.WriteLine(number);


            //// lv 1 num 11
            //int j = 6;
            //for (int i = 1; i < j; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.Write($"{j},");
            //Console.WriteLine();
            //int b = 5;
            //for (int i = 0; i < b; i++)
            //{
            //    Console.Write(b + " ");
            //}
            //Console.Write($"{b}.");
            //Console.WriteLine();

            //// lv 1 num 12
            //double sum = 0;
            //int x = 2;
            //for (int i = 0; i <= 10; i++)
            //{
            //    sum += 1 / Math.Pow(x, i);
            //}
            //Console.WriteLine(sum);

            //// lv 1 num 13
            //Console.WriteLine("x     y");
            //double y13 = 0;
            //for (double x13 = -1.5; x13 < 1.6; x13 += 0.1)
            //{
            //    if (x13 <= -1) y13 = 1;
            //    else if (x13 > -1 && x13 <= 1)
            //    {
            //        if (x13 == 0) y13 = 0;
            //        else y13 = -x13;
            //    }
            //    else if (x13 > 1) y13 = -1;

            //    Console.WriteLine($"{Math.Round(x13, 2)}    {Math.Round(y13, 2)}");
            //}
            // lv 1 num 14
            //int n = 8; 
            //int first = 1;
            //int second = 1;

            //Console.Write(first + " " + second + " "); 

            //for (int i = 3; i <= n; i++)
            //{
            //    int next = first + second; 
            //    Console.Write(next + " ");

            //    first = second; 
            //    second = next; 
            //}

            // lv 1 num 15
            //int n = 5; 
            //int chisl1 = 1; 
            //int znam1 = 1; 
            //int chisl2 = 2; 
            //int znam2 = 1;
            //int chisl= 0; 
            //int znam = 0; 

            //for (int i = 3; i <= n; i++)
            //{
            //    chisl = chisl1 + chisl2; 
            //    znam = znam1 + znam2;
            //    chisl1 = chisl2;
            //    znam1 = znam2;
            //    chisl2 = chisl;
            //    znam2 = znam;
            //}

            //Console.WriteLine("5-й член последовательности: " + (double)chisl/znam);

            //// lv 2 num 1
            //double sum = 0;
            //int x = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += Math.Cos(i * x) / Math.Pow(i, 2);
            //    if (Math.Abs(Math.Cos(i * x) / Math.Pow(i, 2)) < 0.0001)
            //    {
            //        Console.WriteLine(sum);
            //        break;
            //    }
            //}

            // lv 2 num 2
            //int sum = 1;
            //int last_sum = 0;
            //for (int i = 1; i <= 10000; i += 3)
            //{
            //    sum *= i;
            //    if (sum <= 30000)
            //    {
            //        last_sum = sum;
            //    }
            //    if (sum > 30000)
            //    {
            //        Console.WriteLine(last_sum);
            //        break;
            //    }
            //}

            // lv 2 num 3
            // int s = 0, n = 0, m;
            // const int a = 2, h = 3, p = 41;
            // while (s <= p)
            // {
            //     m = a + n * h;
            //     s = s + m;
            //     n = n + 1;
            // }
            // n--;
            // Console.WriteLine($"{n:d}");

            // lv 2 num 4
            //double sum = 0;
            //double x = 0.9;
            //double last_sum = 0;
            //for (int n = 1; n <= 10000; n++)
            //{
            //    sum += Math.Pow(x, n * 2);
            //    if (Math.Pow(x, n * 2) >= 0.0001)
            //    {
            //        last_sum = sum;
            //    }

            //    if (Math.Pow(x, n * 2) < 0.0001)
            //    {
            //        Console.WriteLine(last_sum);
            //        break;
            //    }
            //}


            //// lv 2 num 5
            //double res = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //while (n >= m)
            //{
            //    res += 1;
            //    n -= m;
            //}
            //Console.WriteLine($"частное: {res}");
            //if (n < m)
            //{
            //    if (n > 0)
            //    {
            //        Console.WriteLine($"остаток:{n}");
            //    }
            //    if (n == 0)
            //    {
            //        Console.WriteLine("остаток: 0");
            //    }
            //}

            //// lv 2 num 6
            //int n = 1; 
            //int time = 0; 
            //while (n != 105) 
            //{
            //    time++; 
            //    n += n;
            //    if (n > 105)
            //    {
            //        n = 105;
            //    }
            //}
            //Console.WriteLine("Время: " + time);
            //Console.ReadKey();

            //// lv 2 num 7.1

            //double r = 10;
            //double sum = 10;
            //for (int kolvo = 1; kolvo < 7; kolvo++)
            //{
            //    r = r + r * 0.1;
            //    sum += r;
            //}
            //Console.WriteLine(sum);

            //// lv 2 num 7.2

            //double r = 10;
            //double sum = 10;
            //int kolvo = 1;
            //for (kolvo = 1; sum < 100;)
            //{
            //    r = r + r * 0.1;
            //    sum += r;
            //    kolvo += 1;
            //}
            //Console.WriteLine(kolvo);


            //// lv 2 num 7.3

            //double r = 10;
            //double sum = 10;
            //int kolvo = 1;
            //for (kolvo = 1; r <= 20;)
            //{
            //    r = r + r * 0.1;
            //    kolvo += 1;
            //}
            //Console.WriteLine(kolvo);


            //// lv 2 num 8

            //double vklad = 10000;
            //int month = 0;
            //for (month = 0; vklad < 20000;)
            //{
            //    vklad = vklad * 1.08;
            //    month++;
            //}
            //Console.WriteLine(month);

            // lv 3 num 9

            //double a = 0.1;
            //double b = 1;
            //double h = 0.05;
            //double s = 0;

            //double y(double z)

            //{
            //    return Math.Atan(z);
            //}
            //double def(int i, double z)

            //{
            //    double chisl = Math.Pow(-1, i) * Math.Pow(z, 2 * i + 1);
            //    double znam = 2 * i + 1;
            //    return chisl / znam;
            //}

            //double x = a;
            //while (x <= b)
            //{
            //    int i = 0;
            //    double currentTerm = def(i, x);
            //    while (Math.Abs(currentTerm) >= 0.0001)
            //    {
            //        s += currentTerm;
            //        i++;
            //        currentTerm = def(i, x);
            //    }

            //    Console.WriteLine("x = " + x);
            //    Console.WriteLine("s = " + s);
            //    Console.WriteLine("y = " + y(x));
            //    Console.WriteLine();

            //    x += h;

            //}

        }
    }
}
