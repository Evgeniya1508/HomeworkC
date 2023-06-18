/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int Request(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void CreateMatrix(int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            resMatrix[i,j] = new Random().Next(1,6);
        }
    }
}
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] GetResultMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resMatrix;
}

int row = Request("Введите количество строк в первом массиве:  ");
int column = Request("Введите количество столбцов в первом массиве:  ");
int m = Request("Введите количество строк во втором массиве:  ");
int n = Request("Введите количество столбцов во втором массиве:  ");
int[,] firstMatrix = new int[row, column];
int[,] secondMatrix = new int[m, n];
CreateMatrix(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();
CreateMatrix(secondMatrix);
PrintMatrix(secondMatrix);
if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1)) 
{
    Console.WriteLine("Данные матрицы нельзя перемножить ");
    return;
}
Console.WriteLine("Результирующая матрица будет:");
int[,] resMatrix = GetResultMatrix(firstMatrix, secondMatrix);
PrintMatrix(resMatrix);