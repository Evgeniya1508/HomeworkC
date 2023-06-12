/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве не*/
int Request (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0,100);
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
bool ExistElement(int[,] matrix, int row, int column)
{
    return row < matrix.GetLength(0) && column < matrix.GetLength(1);
}

int row = Request("Введите число, соответствующее позиции элемента по строке в двумерном массиве (считаем от 0):  ");
int column = Request("Введите число, соответствующее позиции элемента по колонке в двумерном массиве (считаем от 0):  ");
int[,] matrix = new int[5, 9];
FillMatrix(matrix);
PrintMatrix(matrix);
if (ExistElement(matrix,row,column))
{
    Console.WriteLine($"Элемент с заданной вами позицией ({row}{column} при счете от 0) равен {matrix[row,column]}");
}
else
{
    Console.WriteLine($"Такого числа в массиве не существует!!!");
}