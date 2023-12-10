// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    internal class Program
    {

        //lab 5
        //num 5

        //static void Main(string[] args)
        //{
        //    int[,] A = new int[4, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,100,11,12},
        //        { 13,14,15,16,17,18},
        //        { 19,20,21,22,23,24}
        //    };
        //    int[,] B = new int[6, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,10,11,12},
        //        { 13,14,15,16,17,18},
        //        { 199,20,221,22,23,24},
        //        { 25,26,27,28,29,30},
        //        { 31,32,33,34,35,36 }
        //    };
        //    int maxA = Max(A, 0);
        //    int maxB = Max(B, 0);
        //    Swap(A, maxA, B, maxB);
        //    Console.WriteLine("матрица A после замены:");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(A[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("матрица B после замены:");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(B[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //static int Max(int[,] C, int index)
        //{
        //    int max = C[0, index];
        //    int maxindex = 0;

        //    for (int i = 1; i < C.GetLength(0); i++)
        //    {
        //        if (C[i, index] > max)
        //        {
        //            max = C[i, index];
        //            maxindex = i;
        //        }
        //    }
        //    return maxindex;
        //}

        //static void Swap(int[,] AA, int rowA, int[,] BB, int rowB)
        //{
        //    int[] t = new int[AA.GetLength(1)];

        //    for (int i = 0; i < AA.GetLength(1); i++)
        //    {
        //        t[i] = AA[rowA, i];
        //        AA[rowA, i] = BB[rowB, i];
        //        BB[rowB, i] = t[i];
        //    }
        //}

        //num 11

        //static void Main(string[] args)
        //{
        //    int[,] A = new int[4, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,100,11,12},
        //        { 13,14,15,16,17,18},
        //        { 19,20,21,22,23,24}
        //    };
        //    int[,] B = new int[6, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,10,11,12},
        //        { 13,14,15,16,17,18},
        //        { 199,20,221,22,23,24},
        //        { 25,26,27,28,29,30},
        //        { 31,32,33,34,35,36 }
        //    };
        //    int maxiA = Maxi(A);
        //    int maxiB = Maxi(B);
        //    int maxjA = Maxj(A);
        //    int maxjB = Maxj(B);

        //    int AB = Max(B);
        //    int BA = Max(A);
        //    A[maxiA, maxjA] = AB;
        //    B[maxiB, maxjB] = BA;


        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(A[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(B[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //static int Max(int[,] C)
        //{
        //    int max = C[0, 0];

        //    for (int i = 0; i < C.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < C.GetLength(0); j++)
        //        {
        //            if (C[i, j] > max)
        //            {
        //                max = C[i, j];
        //            }
        //        }
        //    }
        //    return max;
        //}
        //static int Maxi(int[,] C)
        //{
        //    int max = C[0, 0];
        //    int maxindexR = 0;


        //    for (int i = 0; i < C.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < C.GetLength(0); j++)
        //        {
        //            if (C[i, j] > max)
        //            {
        //                max = C[i, j];
        //                maxindexR = i;
        //            }
        //        }
        //    }
        //    return maxindexR;
        //}
        //static int Maxj(int[,] C)
        //{
        //    int max = C[0, 0];
        //    int maxindexC = 0;

        //    for (int i = 0; i < C.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < C.GetLength(0); j++)
        //        {
        //            if (C[i, j] > max)
        //            {
        //                max = C[i, j];
        //                maxindexC = j;
        //            }
        //        }
        //    }
        //    return maxindexC;
        //}

        //num 17

        //static void Main()
        //{

        //    int[,] A = new int[4, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,100,11,12},
        //        { 13,14,15,16,17,18},
        //        { 19,20,21,22,23,24}
        //    };
        //    int[,] B = new int[6, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,10,11,12},
        //        { 13,14,15,16,17,18},
        //        { 199,20,221,22,23,24},
        //        { 25,26,27,28,29,30},
        //        { 31,32,33,34,35,36 }
        //    };


        //    Sort(ref A);
        //    Sort(ref B);

        //    Console.WriteLine("матрица А:");
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(A[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("матрица В:");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(B[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void Sort(ref int[,] C)
        //{
        //    int rows = C.GetLength(0);
        //    int cols = C.GetLength(1);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        int maxi_r = i;
        //        int max = C[i, 0];
        //        for (int j = 1; j < cols; j++)
        //        {
        //            if (C[i, j] > max)
        //            {
        //                max = C[i, j];
        //            }
        //        }

        //        for (int k = i + 1; k < rows; k++)
        //        {
        //            int maxcur = C[k, 0];
        //            for (int j = 1; j < cols; j++)
        //            {
        //                if (C[k, j] > maxcur)
        //                {
        //                    maxcur = C[k, j];
        //                }
        //            }

        //            if (maxcur > max)
        //            {
        //                max = maxcur;
        //                maxi_r = k;
        //            }
        //        }

        //        if (maxi_r != i)
        //        {
        //            for (int j = 0; j < cols; j++)
        //            {
        //                int t = C[i, j];
        //                C[i, j] = C[maxi_r, j];
        //                C[maxi_r, j] = t;
        //            }
        //        }
        //    }
        //}

        // num 23

        //static void Main()
        //{
        //    int[,] A = new int[4, 6]
        //    {
        //        { 1,2,3,40,5,6},
        //        { 7,8,9,100,11,12},
        //        { 13,14,15,16,17,18},
        //        { 19,20,21,22,23,24}
        //    };
        //    int[,] B = new int[6, 6]
        //    {
        //        { 1,2,3,4,5,6},
        //        { 7,8,9,10,11,12},
        //        { 13,14,15,16,17,18},
        //        { 199,20,221,22,23,24},
        //        { 25,26,27,28,29,30},
        //        { 31,32,33,34,35,36 }
        //    };
        

        //    fivemaxels(A);
        //    fivemaxels(B);
        //}

        //static void fivemaxels(int[,] C)
        //{
            
        //    int rows = C.GetLength(0);
        //    int cols = C.GetLength(1);

        //    int[] largestel = new int[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        largestel[i] = -1;
        //    }

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            int el = C[i, j];
        //            for (int k = 0; k < 5; k++)
        //            {
        //                if (el > largestel[k])
        //                {
        //                    for (int l = 4; l > k; l--)
        //                    {
        //                        largestel[l] = largestel[l - 1];
        //                    }
        //                    largestel[k] = el;
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    Console.WriteLine("пять наибольших элементов матрицы:") ;
        //    foreach (int element in largestel)
        //    {
        //        Console.WriteLine(element);
        //    }

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            if (Array.IndexOf(largestel,C[i, j]) != -1 )
        //            {
        //                C[i, j] *= 2;
        //            }
        //            else
        //            {
        //                C[i, j] /= 2;
        //            }
                    
                       
        //        }
        //    }
        //    Console.WriteLine("преобразованная матрица:");
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write(C[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}



    }

}
