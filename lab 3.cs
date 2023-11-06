using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {




            // lab 3
            ////lv 1 num 1

            //double[] a = new double[6];
            //string s;
            //for (int i = 0; i < 6; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    sum += a[i];
            //}
            //Console.WriteLine("сумма элементов массива: "+sum);
            //if (sum != 0)
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        a[i] /= sum;
            //        Console.WriteLine("массив после деления: " + a[i]);
            //    }
            //}


            ////lv 1 num 2

            //double[] mas = new double[8];
            //string s;
            //for (int i = 0; i < 8; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //double kolvo = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    if (mas[i] > 0)
            //    {
            //        sum += mas[i];
            //        kolvo++;
            //    }
            //}
            //double sred = sum / kolvo; //7,4
            //for (int i = 0; i < 8; i++)
            //{
            //    if (mas[i] >= 0)
            //    {
            //        mas[i] = sred;
            //    }
            //}
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            //// lv 1 num 3

            //double[] mas1 = new double[4];
            //string s;
            //Console.WriteLine("первый массив:");
            //for (int i = 0; i < 4; i++)
            //{
            //    s = Console.ReadLine();
            //    mas1[i] = double.Parse(s);
            //}
            //double[] mas2 = new double[4];
            //string k;
            //Console.WriteLine("второй массив:");
            //for (int i = 0; i < 4; i++)
            //{
            //    k = Console.ReadLine();
            //    mas2[i] = double.Parse(k);
            //}
            //double[] massum = new double[4];
            //double[] masraz = new double[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    massum[i] = mas1[i] + mas2[i]; 
            //    masraz[i] = mas1[i] - mas2[i]; 
            //}
            //Console.WriteLine("Сумма массивов:");
            //foreach (int num in massum)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Разность массивов:");
            //foreach (int num in masraz)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();


            // lv 1 num 4

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0;i < 5; i++)
            //{  sum += mas[i]; }
            //double sred = sum / 5.0; 
            //Console.WriteLine("среднее значение: "+sred);
            //for (int i = 0; i < 5; i++)
            //{
            //    mas[i] = mas[i] - sred;

            //}
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            ////lv 1 num 5

            //double[] mas1 = new double[4];
            //string s;
            //Console.WriteLine("первый массив:");
            //for (int i = 0; i < 4; i++)
            //{
            //    s = Console.ReadLine();
            //    mas1[i] = double.Parse(s);
            //}

            //double[] mas2 = new double[4];
            //string k;
            //Console.WriteLine("второй массив:");
            //for (int i = 0; i < 4; i++)
            //{
            //    k = Console.ReadLine();
            //    mas2[i] = double.Parse(k);
            //}
            //double skal = 0;
            //for (int i = 0;i < 4; i++)
            //{
            //    skal += mas1[i] * mas2[i];
            //}
            //Console.WriteLine(skal);


            // lv 1 num 6

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}

            //for (int i = 0;i < 5; i++)
            //{
            //    mas[i] = mas[i] * mas[i];
            //}
            //Console.WriteLine("массив в квадрате");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}
            //double sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    sum += mas[i];
            //}
            //Console.WriteLine(Math.Sqrt(sum));


            // lv 1 num 7

            //double[] mas = new double[7];
            //string s;
            //for (int i = 0; i < 7; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 7; i++)
            //{
            //    sum += mas[i];
            //}
            //double srzn = 0;
            //srzn = sum/7.0 ;
            //Console.WriteLine("среднее значение массива: "+srzn); 
            //for (int i = 0; i < 7; i++)
            //{
            //    if (mas[i] < srzn)
            //    {
            //        mas[i] = 0;
            //    }
            //}
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 1 num 8

            //double[] mas = new double[6];
            //string s;
            //for (int i = 0; i < 6; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //int count = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine("количество отрицательных элементов: " + count);


            //lv 1 num 9

            //double[] mas = new double[8];
            //string s;
            //for (int i = 0; i < 8; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 8; i++)
            //{
            //    sum += mas[i];
            //}
            //double srzn = 0;
            //srzn = sum / 8.0;
            //Console.WriteLine("среднее значение массива: " + srzn);
            //int count = 0;
            //for (int i = 0;i < 8;i++)
            //{
            //    if (mas[i] > srzn)
            //    {
            //        count += 1;
            //    }
            //}
            //Console.WriteLine(count);


            // lv 1 num 10

            //double[] mas = new double[10];
            //string s;
            //for (int i = 0; i < 10; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //Console.WriteLine("введите P ");
            //double P = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("введите Q");
            //double Q = Convert.ToDouble(Console.ReadLine());
            //int count = 0;
            //for (int i = 0;i < 10;i++)
            //{
            //    if (mas[i] > P && mas[i] < Q)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("количество элементов: "+count);


            // lv 1 num 11

            //double[] mas = new double[10];
            //string s;
            //for (int i = 0; i < 10; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //int count = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (mas[i] > 0)
            //    {
            //        count++;
            //    }
            //}
            //double[] mas2 = new double[count];
            //int k = 0;
            //for (int i = 0; i < 10; i++) 
            //{ 
            //    if (mas[i] >= 0)
            //    {
            //        mas2[k] = mas[i];
            //        k++;
            //    }
            //}
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(mas2[i]);
            //}


            // lv 1 num 12

            //double[] mas = new double[8];
            //string s;
            //for (int i = 0; i < 8; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //for (int i = 7; i >= 0; i--)
            //{
            //    if (mas[i] < 0 )
            //    { 
            //        Console.WriteLine("значение последнего отрицательного элемента: "+mas[i]);
            //        Console.WriteLine("номер последнего элемента: "+(i+1));
            //        break;
            //    }
            //}


            // lv 1 num 13

            //double[] mas = new double[10];
            //string s;
            //for (int i = 0; i < 10; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}

            //double[] chet = new double[5];
            //double[] nechet = new double[5];
            //int k = 0;
            //int j = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (mas[i] % 2 == 0)
            //    {
            //        chet[k] = mas[i];
            //        k++;
            //    }
            //    else
            //    {
            //        nechet[j] = mas[i];
            //        j++;
            //    }
            //}
            //Console.WriteLine("полученный четный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(chet[i]);
            //}
            //Console.WriteLine("полученный нечетный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(nechet[i]);
            //}


            // lv 1 num 14

            //double[] mas = new double[11];
            //string s;
            //for (int i = 0; i < 11; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    if (mas[i] > 0)
            //    {
            //        mas[i] = mas[i] * mas[i];
            //        sum += mas[i];
            //    }
            //    else { break; }
            //}
            //Console.WriteLine("сумма: "+sum);


            // lv 1 num 15

            //double[] x = new double[10];
            //string s;
            //for (int i = 0; i < 10; i++)
            //{
            //    s = Console.ReadLine();
            //    x[i] = double.Parse(s);
            //}
            //double[] y = new double[10];
            //int j = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    y[j] = 0.5 * Math.Log(x[i]);
            //    j++;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{x[i]}     {y[i]}");
            //}




            // lv 2 num 1

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double amin = mas[0];

            //for (int i = 0; i < 5; i++)
            //    if (mas[i] < amin)
            //    {
            //        amin = mas[i];

            //    }
            //Console.WriteLine("мин эл " + amin);
            //for (int i = 0; i < 5; i++)
            //    if (mas[i] == amin)
            //    {
            //        mas[i] = mas[i] * 2;
            //    }
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 2

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double amax = mas[0];

            //for (int i = 0; i < 5; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];

            //    }
            //double sum = 0;
            //Console.WriteLine("макс эл " + amax);
            //for (int i = 0; i < 5; i++)
            //    if (mas[i] != amax)
            //    {
            //        sum += mas[i];
            //    }
            //    else { break; }
            //Console.WriteLine(sum);


            // lv 2 num 3

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double amin = mas[0];

            //for (int i = 0; i < 5; i++)
            //    if (mas[i] < amin)
            //    {
            //        amin = mas[i];

            //    }
            //Console.WriteLine("мин эл " + amin);
            //for (int i = 0; i < 5; i++)
            //    if (mas[i] != amin)
            //    {
            //        mas[i] = mas[i] * 2;
            //    }
            //    else { break; }
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 4

            //double[] mas = new double[5];
            //string s;
            //for (int i = 0; i < 5; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double amax = mas[0];

            //for (int i = 0; i < 5; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];

            //    }
            //double sum = 0;
            //Console.WriteLine("макс эл " + amax);

            //for (int i = 0; i < 5; i++)
            //{
            //    sum += mas[i];
            //}
            //double srzn = 0;
            //srzn = sum / 5.0;
            //Console.WriteLine("среднее значение массива: " + srzn);

            //for (int i = 4; i >= 0; i--)
            //if (mas[i] != amax)
            //{
            //        mas[i] = srzn;
            //}
            //else { break; }
            //for (int i = 0;i < 5; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 5

            // double[] mas = { -3, 46, -9, 6, -6, -10 };
            // double amax = mas[0];
            // double amin = mas[0];
            // int indexmax = 0;
            // int indexmin = 0;
            // for (int i = 0; i < 6; i++)
            //     if (mas[i] > amax)
            //     {
            //         amax = mas[i];
            //         indexmax = i;

            //     }
            // double sum = 0;
            // Console.WriteLine("макс эл " + amax);

            // for (int i = 0; i < 6; i++)
            //     if (mas[i] < amin)
            //     {
            //         amin = mas[i];
            //         indexmin = i;

            //     }
            // Console.WriteLine("мин эл " + amin);

            // double[] y = new double[2];
            // int j = 0;
            // for (int i = 0; i < 6; i++)
            // {
            //     if ((i > indexmax) && (i < indexmin) && (mas[i] < 0) )
            //     {
            //         y[j] = mas[i];
            //         j++;
            //     }
            // }

            //for (int i = 0;  i < 2; i++)
            // {
            //     Console.WriteLine(y[i]);
            // }


            // lv 2 num 6

            //double[] mas = {1,2,3,4,5};
            //double[] mas2 = new double[6];
            //double sum = 0;
            //Console.WriteLine("Введите число Р:");
            //double P = Convert.ToDouble(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    sum += mas[i];
            //}
            //double srzn = 0;
            //srzn = sum / 5;
            //Console.WriteLine("среднее значение: " + srzn);
            //int index = 0;
            //double razn = 0;
            //double raznmin = 10;
            //for (int i = 0; i < 5; i++)
            //{
            //    razn = Math.Abs(mas[i] - srzn);
            //    if (razn < raznmin)
            //    { 
            //        raznmin = razn;
            //        index = i;
            //    }
            //}
            //int j = 0;
            //mas2[index+1] = P;
            //for (int i = 0; i < 5; i++) 
            //{
            //    if (i <= index)
            //    {
            //        mas2[j] = mas[i];
            //        j++;
            //    }
            //    else
            //    {
            //        mas2[j + 1] = mas[i];
            //        j++;
            //    }       
            //}
            //for (int i = 0;i < 6; i++)
            //{
            //    Console.WriteLine(mas2[i]);
            //}


            // lv 2 num 7

            //double[] mas = { -3, 46, 9, 6, -6, -10 };
            //double amax = mas[0];
            //int indexmax = 0;
            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }
            //mas[indexmax+1] *= 2;
            //for (int i = 0;i < 6; i++) 
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 8

            //int[] mas = { -30, 46, 9, 6, -6, -10 };
            //int amax = -100;
            //int amin = 100;
            //int indexmax = 0;
            //int indexmin = 0;
            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }

            //for (int k = 5; k >= 0; k--)
            //    if (k != indexmax)
            //    {
            //        if ((mas[k] < amin))
            //        {
            //            amin = mas[k];
            //            indexmin = k;
            //        }
            //    }
            //    else { break; }

            //Console.WriteLine("amax "+amax);
            //Console.WriteLine("amin "+amin);
            //Console.WriteLine("indexmax "+indexmax);
            //Console.WriteLine("indexmin "+indexmin);

            //mas[indexmin] = amax;
            //mas[indexmax] = amin;

            //for (int i = 0;i < 6; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 9

            //double[] mas = { -3, 46, 9, 6, -6, -10 };
            //double amax = -100;
            //double amin = 100;
            //int indexmax = 0;
            //int indexmin = 0;
            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }

            //for (int k = 5; k >= 0; k--)
            //    if ((mas[k] < amin))
            //    {
            //        amin = mas[k];
            //        indexmin = k;
            //    }

            //double sum = 0;
            //int kolvo = 0;
            //double res = 0;

            ////Console.WriteLine("amax " + amax);
            ////Console.WriteLine("amin " + amin);
            ////Console.WriteLine("indexmax " + indexmax);
            ////Console.WriteLine("indexmin " + indexmin);

            //for (int i = 0;i < 6; i++)
            //{
            //    if ((i > indexmin && i < indexmax) | (i < indexmin && i > indexmax))
            //    {
            //        sum += mas[i];
            //        kolvo++;
            //    }
            //}
            //res = sum / kolvo;
            //Console.WriteLine(res);


            // lv 2 num 10

            //double[] mas = { -3, 46, -9, 6, -6, -10 };
            //double amax = -100;
            //double amin = 100;
            //int indexmax = 0;
            //int indexmin = 0;


            //for (int i = 0; i < 6; i++)
            //    if (mas[i] < amin && mas[i] > 0)
            //    {
            //        amin = mas[i];
            //        indexmin = i;

            //    }
            //Console.WriteLine("мин полож эл " + amin);
            //double[] mas2 = new double[5];
            //int j = 0;
            //for (int i = 0;i < 6; i++)
            //{
            //    mas2[j] = mas[i];
            //    if (mas2[j] == amin)
            //    {
            //        continue;
            //    }
            //    j++;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(mas2[i]);
            //}


            // lv 2 num 11

            //double[] mas = { -3, 46, -9, 6, -6, -10 };
            //Console.WriteLine("введите число Р:");
            //double P = Convert.ToDouble(Console.ReadLine());
            //double[] mas2 = new double[7];
            //int index = 0;
            //int j = 0;
            //for (int i = 5; i >= 0; i--)
            //{
            //    if (mas[i] > 0)
            //    {
            //        index = i;
            //        break;
            //    }

            //}
            //for (int i = 0;  i < 6; i++)
            //{
            //    mas2[index + 1] = P;
            //    if (i <= index)
            //    {
            //        mas2[j] = mas[i];

            //    }
            //    else 
            //    { 
            //        mas2[j+1] = mas[i];

            //    }


            //    j++;
            //}
            //Console.WriteLine("полученный массив:");
            //for(int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(mas2[i]);
            //}


            // lv 2 num 12

            //double[] mas = { -3, 46, 9, 6, -6, -10 };
            //double amax = -100;
            //int indexmax = 0;
            //double sum = 0;

            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }

            //for (int i = 0; i < 6; i++)
            //    if (i > indexmax)
            //    {
            //        sum += mas[i];
            //    }

            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        mas[i] = sum;
            //        break;
            //    }
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 13

            //double[] mas = { -3, 46, 9, 6, -6, -10 };
            //double amax = -100;
            //int indexmax = 0;
            //double sum = 0;

            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax && (i % 2 == 0))
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }
            //mas[indexmax] = indexmax;

            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 14

            //int[] mas = { -3, 46, 9, 6, -6, -10 };
            //int amax = -100;
            //int amin = 100;
            //int indexmax = 0;
            //int indexmin = 0;
            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > amax)
            //    {
            //        amax = mas[i];
            //        indexmax = i;

            //    }

            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        indexmin = i;
            //        amin = mas[i];
            //        break;
            //    }
            //}

            //mas[indexmin] = amax;
            //mas[indexmax] = amin;

            //for (int i = 0;i < 6; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 15

            //    Console.WriteLine("введите размер массива А");
            //    int n = int.Parse(Console.ReadLine());
            //    Console.WriteLine("введите размер массива B");
            //    int m = int.Parse(Console.ReadLine());
            //    Console.WriteLine("введите число k");
            //    int k = int.Parse(Console.ReadLine());

            //    Random p = new Random();
            //    double[] A = new double[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        A[i] = p.Next(1,100);
            //    }
            //    double[] B = new double[m];
            //    for (int i = 0; i < m; i++)
            //    {
            //        B[i] = p.Next(1,100);
            //    }
            //    Console.WriteLine("массив А:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine(A[i]);
            //    }
            //    Console.WriteLine("массив В:");
            //    for (int i = 0; i < m; i++)
            //    {
            //        Console.WriteLine(B[i]);
            //    }

            //    double[] mas = new double[n+m];

            //    int j = 0;

            //    for (int i = 0; i <= k; i++)
            //    {
            //        mas[i] = A[i];
            //    }
            //    for (int i = 0; i < m; i++)
            //    {
            //        mas[k + i + 1] = B[i];
            //    }
            //    for (int i = k + m + 1; i < n + m; i++)
            //    {
            //        mas[i] = A[i - m];
            //    }
            //Console.WriteLine("полученный массив:");
            //    for (int i = 0; i < (m+n) ; i++) 
            //    {
            //        Console.WriteLine(mas[i]);
            //    }


            // lv 2 num 16

            //double[] mas = new double[6];
            //string s;
            //for (int i = 0; i < 6; i++)
            //{
            //    s = Console.ReadLine();
            //    mas[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    sum += mas[i];
            //}
            //double srzn = sum / 6.0;
            //Console.WriteLine("среднее значение массива: " + srzn);
            //int count = 0;
            //int j = 0;

            //int countm = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < srzn)
            //    {
            //        countm++;
            //    }
            //}
            //int[] mas2 = new int[countm];
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < srzn)
            //    {
            //        mas2[j] = i;
            //        j++;
            //    }
            //}
            //Console.WriteLine("полученный массив:");
            //for (int i = 0; i < countm; i++)
            //{
            //    Console.WriteLine(mas2[i]);
            //}


            // lv 2 num 17

            //int[] mas = { -3, 46, 9, 6, -6, -10 };

            //double maxel = -100;
            //double minel = 100;
            //int countp = 0;
            //double sump = 0;
            //int counto = 0;
            //double sumo= 0;
            //int indexmax = 0;
            //int indexmin = 0;
            //double resp = 0;
            //double respo = 0;
            //for (int i = 0; i < 6; i++)
            //    if (mas[i] > maxel)
            //    {
            //        maxel = mas[i];
            //        indexmax = i;
            //    }

            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < minel)
            //    {
            //        minel = mas[i];
            //        indexmin = i;
            //    }
            //}

            //if (indexmax < indexmin)
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (mas[i] > 0)
            //        {
            //            sump += mas[i];
            //            countp++;
            //        }
            //    }
            //    Console.WriteLine((sump / countp));
            //}
            //else
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (mas[i] < 0)
            //        {
            //            sumo += mas[i];
            //            counto++;
            //        }
            //    }
            //    Console.WriteLine((sumo / counto));
            //}


            // lv 2 num 18

            // double[] mas = { -3, 46, 9, 6, -6, -10 };
            // double amaxchet = -100;
            // int indexmax = 0;
            // double amaxnech = -100;
            // int indexmaxnech = 0;
            // double sum = 0;

            // for (int i = 0; i < 6; i++)
            //     if (mas[i] > amaxchet && (i % 2 == 0))
            //     {
            //         amaxchet = mas[i];
            //     }

            // for (int i = 0; i < 6; i++)
            //     if (mas[i] > amaxnech && (i % 2 != 0))
            //     {
            //         amaxnech = mas[i];
            //     }
            // Console.WriteLine("макс среди четных индексов: "+amaxchet);
            // Console.WriteLine("макс среди нечетных индексов: "+amaxnech);
            // if(amaxchet > amaxnech)
            // for(int i = 0; i < 3;i++)
            //     {
            //         mas[i] = 0;
            //     }
            //else
            //for (int i = 5; i >= 3;i--)
            //     {
            //         mas[i] = 0;
            //     }
            // Console.WriteLine("полученный массив:");
            // for (int i = 0;i < 6; i++)
            // {
            //     Console.WriteLine(mas[i]);
            // }


            // lv 2 num 19

            //int[] mas = { -3, 46, 9, 6, -6, -10 };

            //double maxel = -100;
            //double sum = 0;
            //int index = 0;

            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] > maxel)
            //    {
            //        maxel = mas[i];
            //        index = i;
            //    }
            //    sum += mas[i];
            //}

            //if (maxel > sum)
            //{
            //    mas[index] = 0;
            //}
            //else
            //{ 
            //    mas[index] *= 2; 
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(mas[i]);
            //}


            // lv 2 num 20

            //int[] mas = { -3, 46, 15, 6, -6, -10 };

            //double firstotr = 100;
            //int indexotr = 0;
            //double minel = 100;
            //int indexmin = 0;
            //double sumchet = 0;
            //double sumnech = 0;

            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        indexotr = i;
            //        break;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] < minel)
            //    {
            //        minel = mas[i];
            //        indexmin = i;
            //    }
            //}
            //if (indexotr < indexmin)
            //{   for (int i = 0; i < 6; i += 2)
            //    {
            //        sumchet += mas[i];
            //    }
            //    Console.WriteLine(sumchet); 
            //}
            //else
            //{
            //    for (int i = 1;i < 6; i+= 2)
            //    {
            //        sumnech += mas[i];
            //    }
            //    Console.WriteLine(sumnech);



            // lv 3 num 2

            //int[] mas = { -3, 46, 9, 46, -6, -10 };

            //int maxel = -100;
            //int k = 1;
            //int index = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] > maxel)
            //    {
            //        maxel = mas[i];
            //        index = i;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] == maxel)
            //    {
            //        mas[i] += k;
            //        k++;
            //    }
            //    Console.WriteLine(mas[i]);
            //}


            // lv 3 num 3

            //int[] mas = { -3, 6, 9, 6, 46, -10 };

            //int maxel = 0;
            //int index = -1;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (mas[i] > maxel)
            //    {
            //        maxel = mas[i];
            //        index = i;
            //    }
            //}
            //for (int i = 0; i < index - 1; i += 2)
            //{
            //    int x = mas[i];
            //    mas[i] = mas[i + 1];
            //    mas[i + 1] = x;
            //}
            //foreach (int numb in mas)
            //{
            //    Console.WriteLine(numb);
            //}












        }
    }
}      
