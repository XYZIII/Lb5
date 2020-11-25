﻿using LB5_Number3.MatrixSolution;
using System;

namespace LB5_Number3
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] MatrixClasses = {"Обычная матрица", "Единичная матрица", "Верхняя треугольная матрица"};
            Console.Write("Hello");
            while (true)
            {
                Console.WriteLine("Какая матрица: ");
                for (int i = 0; i < MatrixClasses.Length; i++)
                    Console.WriteLine($"{i + 1}. {MatrixClasses[i]}");
                Console.Write("--> ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите размерность матрицы:");
                Console.Write("Рядков:");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.Write("Столбцов:");
                int c = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Matrix matrix = new Matrix(r, c);
                            matrix.Show();

                            matrix.Add(1, 1, 50);
                            matrix.Add(2, 1, 150);
                            matrix.Add(3, 1, 250);
                            matrix.Add(3, 2, 350);
                            matrix.Add(1, 3, 450);
                            matrix.Show();

                            matrix.Delete(2, 1);
                            matrix.Delete(1, 3);
                            matrix.Show();

                            matrix.Clear();
                            matrix.AutoAdd();
                            matrix.Show();
                            matrix.Clear();

                            matrix.Add();
                            matrix.Show();

                            matrix.Clear();
                            matrix.Show();
                            break;
                        }
                    case 2:
                        {
                            SingleMatrix single = new SingleMatrix(r, c);
                            single.Show();
                            single.Clear();
                            single.Show();
                            single.Add();
                            single.Show();
                            break;
                        }
                    case 3:
                        {
                            UpperTriangularMatrix upper = new UpperTriangularMatrix(r, c);
                            upper.Show();
                            upper.Clear();
                            upper.Add();
                            upper.Show();
                            break;
                        }

                }
                Console.WriteLine("Для продолжения нажмите ENTER; Чтобы выйти введите -Q- или -q-");
                string s = Console.ReadLine();
                if (s == "Q" || s == "q")
                    break;
            }
        }
    }
}
