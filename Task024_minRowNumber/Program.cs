/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/
int Request (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result;
}
int[,] GetMatrix(int row, int column)
{
    int[,] resMatrix = new int[row,column];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            resMatrix[i,j] = new Random().Next(0,11);
            Console.Write(resMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return resMatrix;
}
void MinRowNumber(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minRowNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRowNum = i + 1;
        } 
    }
    Console.WriteLine($"Cтрока {minRowNum} содержит элементы, дающие наименьшую сумму по строке в массиве (сумма {minSum})");
}
int row = Request("Введите количество строк двумерного массива  ");
int column = Request("Введите количество столбцов двумерного массива  ");
if (row == column)
{
    Console.WriteLine($"Ошибка! Количество строк должно быть больше или меньше количества столбцов!!!");
    return;
}
int[,] resMatrix = GetMatrix(row,column);
MinRowNumber(resMatrix);