/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int Request (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int[,] GetMatrix(int m,int n,int minValue,int maxValue)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minValue,maxValue + 1);
        }
    }
    return matrix;
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
void FindArithMean(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i+1} равно {Math.Round(sum/matrix.GetLength(0),2)}");    
    }    
}
int m = Request("Введите количество строк в массиве =  ");
int n = Request("Введите количество столбцов в массиве = ");
int minValue = Request("Введите минимальное целое значение элемента массива = ");
int maxValue = Request("Введите максимальное целое значение элемента массива = ");
int[,] resMatrix = GetMatrix(m,n,minValue,maxValue);
PrintMatrix(resMatrix);
FindArithMean(resMatrix);

  


