using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lab 4
            //lv 1 num 3

            //int[,] A = new int[,] { { 1, 2, 3, 10 }, { 5, 1, 10, 8 }, { 9, 10, 1, 12 }, { 10, 14, 15, 1 } };

            //int sum = 0;
            //for (int i = 0; i < 4; i++)
            //{
            //    sum += A[i, i];
            //}

            //Console.WriteLine("сумма диагональных элементов: " + sum);


            //lv 1 num 7

            //int[,] A = { { 1, 20, 3, 46, 50 }, { 7, 27, 35, 14, 52 }, { 10, 92, 43, 45, 59 } };

            //int[] maxi = new int[5];
            //for (int j = 0; j < 5; j++)
            //{
            //    int max = A[0, j];
            //    for (int i = 1; i < 3; i++)
            //    {
            //        if (A[i, j] > max)
            //        {
            //            max = A[i, j];
            //        }
            //    }
            //    maxi[j] = max;
            //}

            //Console.WriteLine("массив из максимальных элементов столбцов:");
            //foreach (int val in maxi)
            //{
            //    Console.Write(val + " ");
            //}

            //lv 1 num 11

            //int[,] A = new int[5, 7]
            //{
            //{5, 4, 3, 2, 1, 0, 9},
            //{1, 2, 3, 4, 5, 6, 7},
            //{9, 8, 7, 6, 5, 4, 3},
            //{-9, 1, 2, 3, 4, 5, 6},
            //{2, 3, 1, 6, 7, 8, 4}
            //};

            //int imin = 0;
            //int min = A[0, 0];

            //for (int i = 1; i < 5; i++)
            //{
            //    if (A[i, 0] < min)
            //    {
            //        min = A[i, 0];
            //        imin = i;
            //    }
            //}
            //int[,] B = new int[4, 7];
            //int index = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i != imin)
            //    {
            //        for (int j = 0; j < 7; j++)
            //        {
            //            B[index, j] = A[i, j];
            //        }
            //        index++;
            //    }
            //}

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 1 num 15

            //int[,] A = new int[5, 7]
            //{
            //{1, 2, 3, 4, 5, 6, 7},
            //{8, 9, 250, 11, 12, 13, 14},
            //{15, 16, 17, 18, 100, 20, 21},
            //{22, 23, 24, 25, 26, 150, 28},
            //{29, 30, 50, 32, 33, 34, 35}
            //};

            //int imax = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    int maxel = A[i, 0];
            //    for (int j = 1; j < 7; j++)
            //    {
            //        if (A[i, j] > maxel)
            //        {
            //            maxel = A[i, j];
            //            imax = j;
            //        }
            //    }
            //    A[i, imax] *= (i + 1);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //lv 1 num 19

            //Console.WriteLine("введите количество строк массива - n:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите количество столбцов массива - m:");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите массив:");
            //int[,] C = new int[n, m];
            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < m; j++)
            //    {
            //        string s = Console.ReadLine();
            //        C[i, j] = Convert.ToInt32(s);
            //    }
            //for (int i = 0; i < n; i++)
            //{
            //    int max = -10000;
            //    int imax = -1;


            //    for (int j = 0; j < m; j++)
            //    {
            //        if (C[i, j] > max)
            //        {
            //            max = C[i, j];
            //            imax = j;
            //        }
            //    }


            //    for (int j = 0; j < imax; j++)
            //    {
            //        if (C[i, j] < 0)
            //        {
            //            C[i, j] /= max;
            //        }
            //    }
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(C[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //lv 1 num 23

            //int[,] G =
            //{
            //    {1,2,3,4,5,6,0 },
            //    {8,9,10,11,12,13,0},
            //    {15,166,17,18,19,20,0},
            //    {22,23,24,255,26,27,0},
            //    {29,30,331,32,33,34,0}
            //};
            //for (int i = 0; i < 5; i++)
            //{
            //    int maxel = -100;
            //    int imax = -1;

            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (G[i, j] > maxel)
            //        {
            //            maxel = G[i, j];
            //            imax = j;
            //        }

            //    }
            //    for (int k = 5; k >= imax; k--)
            //    {
            //        G[i, k + 1] = G[i, k];
            //    }
            //    G[i,imax+1] = maxel;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(G[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 1 num 27

            //int[,] B =
            //{
            //    {1, 3, 4, 2, 8, 5, 6},
            //    {6, 2, 5, 7, 1, 9, 3},
            //    {9, 4, 8, 2, 5, 3, 1},
            //    {4, 6, 2, 9, 1, 7, 3},
            //    {7, 5, 3, 8, 1, 4, 6}
            //};

            //int[] maxel = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    int max = -100;

            //    for (int j = 0; j < 7; j++)
            //    {
            //        if (B[i, j] > max)
            //        {
            //            max = B[i, j];
            //        }
            //    }

            //    maxel[i] = max;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    B[i, 4] = maxel[5 - i - 1];
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(B[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //lv 1 num 31

            //int[,] A = new int[5, 7] 
            //{
            //    {1, 3, 4, 2, 5, 8, 9},
            //    {6, 2, 5, 7, 8, 0, 3},
            //    {9, 4, 8, 2, 1, 3, 5},
            //    {4, 6, 2, 9, 3, 1, 7},
            //    {7, 5, 3, 8, 6, 4, 9}
            //};

            //int imin = 0;
            //int minel = A[4, 0];

            //for (int i = 1; i < 7; i++)
            //{
            //    if (A[4, i] < minel)
            //    {
            //        minel = A[4, i];
            //        imin = i;
            //    }
            //}

            //int[] B = new int[] { 1, 2, 3, 4, 5 };

            //int[,] result = new int[5, 8];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= imin; j++)
            //    {
            //        result[i, j] = A[i, j];
            //    }

            //    result[i, imin + 1] = B[i];

            //    for (int j = imin + 2; j < 8; j++)
            //    {
            //        result[i, j] = A[i, j - 1];
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Console.Write(result[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 2

            //lv 2 num 3

            //int[,] A = new int[10,5]
            //{
            //    {1,2,3,4,5},
            //    {6,7,8,9,100},
            //    {11,12,13,144,15},
            //    {16,177,18,19,20},
            //    {21,22,23,24,25},
            //    {31,27,288,29,30},
            //    {331,32,33,34,35},
            //    {36,37,38,39,40},
            //    {41,42,43,44,45},
            //    {46,47,48,49,50}
            //};

            //for (int j = 0; j < 5; j++)
            //{

            //    int max = A[0, j];
            //    int imax = 0;

            //    for (int i = 1; i < 10; i++)
            //    {
            //        if (A[i, j] > max)
            //        {
            //            max = A[i, j];
            //            imax = i;
            //        }
            //    }

            //    if (imax < 5)
            //    {
            //        int sum = 0;
            //        for (int i = imax + 1; i < 10; i++)
            //        {
            //            sum += A[i, j];
            //        }
            //        A[0, j] = sum;
            //    }

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 2 num 7


            //int[,] A = new int[6, 6]
            //{
            //    {1,2,3,4,5,6},
            //    {7,8,9,10,11,12},
            //    {13,14,155,16,17,18 },
            //    {19,20,21,22,23,24},
            //    {25,26,27,28,29,30},
            //    {31,32,33,34,35,36}
            //};
            //int max = A[0, 0];
            //int imax = 0;

            //for (int i = 0; i < 6; i++)
            //{
            //    if (A[i,i]> max)
            //    {
            //        max = A[i,i];
            //        imax = i;
            //    }
            //}
            //for (int i = 0;i < imax; i++)
            //{
            //    for (int j = imax + 1;j < 6; j++)
            //    {
            //        A[i, j] = 0;
            //    }
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.Write(A[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 3
            //lv 3 num 1

            //int[,] A = new int[7, 5]
            //{
            //    {1,2,3,4,5},
            //    {60,7,8,9,100},
            //    {2,12,13,144,15},
            //    {16,177,18,19,20},
            //    {3,22,23,24,25},
            //    {31,27,288,29,30},
            //    {331,32,33,34,35}
            //};


            //int[] minels = new int[7];
            //for (int i = 0; i < 7; i++)
            //{
            //    int min = A[i, 0];
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (A[i, j] < min)
            //        {
            //            min = A[i, j];
            //        }
            //    }
            //    minels[i] = min;
            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = i + 1; j < 7; j++)
            //    {
            //        if (minels[j] > minels[i])
            //        {
            //            int t = minels[i];
            //            minels[i] = minels[j];
            //            minels[j] = t;

            //            for (int k = 0; k < 5; k++)
            //            {
            //                t = A[i, k];
            //                A[i, k] = A[j, k];
            //                A[j, k] = t;
            //            }
            //        }
            //    }
            //}


            //for (int i = 0; i < 7; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(A[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //lv 3 num 10

            int[,] A = new int[5, 3] 
            { 
                { 5, 8, 3 }, 
                { 4, 9, 1 }, 
                { 6, 7, 2 },
                { 8, 9, 3 },
                { 10, 11, 4 }
            };
            
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = j + 1; k < 3; k++)
                        {
                            if (A[i, j] < A[i, k])
                            {
                                int temp = A[i, j];
                                A[i, j] = A[i, k];
                                A[i, k] = temp;
                            }
                        }
                    }
                }
                else
                {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = j + 1; k < 3; k++)
                    {
                        if (A[i, j] > A[i, k])
                        {
                            int temp = A[i, j];
                            A[i, j] = A[i, k];
                            A[i, k] = temp;
                        }
                    }
                }
             }
        }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
