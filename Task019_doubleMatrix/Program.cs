﻿/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int Request(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double[,] CreateDoubleNumMatrix(int m, int n)
{
    double[,] matrix = new double [m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(new Random().NextDouble()*100,2);
        }
    }
    return matrix;
}
void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int m = Request ("Введите количество строк в массиве ");
int n = Request ("Введите количество столбцов в массиве ");
double[,] resMatrix = CreateDoubleNumMatrix(m,n);
PrintMatrix(resMatrix);