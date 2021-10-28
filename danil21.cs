﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {

        static void fillMatr(int[,] mt, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mt[i, j] = rnd.Next(0, 10);
                }
            }
        }
        static void Outpuit(int[,] mt, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mt[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Mathh(int[,] A1, int[,] A2, int[,] C, int n1, int n2, int m1, int m2)
        {
            if (m1 != n2)
            {
                Console.WriteLine("Умножение невозможно");
            }
            else
            {
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < m1; k++)
                        {
                            C[i, j] += A1[i, k] * A2[k, j];
                        }
                        Console.Write(C[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] A1;
            int n1, m1, n2, m2;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            A1 = new int[n1, m1];
            int[,] A2 = new int[n2, m2];
            int[,] C = new int[n1, m2];
            fillMatr(A1, n1, m1);
            fillMatr(A2, n2, m2);
            Console.WriteLine("Матрица A:");
            Outpuit(A1, n1, m1);
            Console.WriteLine("Матрица A2:");
            Outpuit(A2, n2, m2);
            Console.WriteLine("Произведение:");
            Mathh(A1, A2, C, n1, n2, m1, m2);
            Console.ReadKey();
        }
    }
}




