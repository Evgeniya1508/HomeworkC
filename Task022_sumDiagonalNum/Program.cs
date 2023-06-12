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
void SumOfDiagonalNum(int[,]matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum +=matrix[i,j];
        }  
    } 
    Console.WriteLine($"Сумма элементов, находящихся на главной диагонали в данном массиве, равна {sum}.");  
}
int m = Request("Введите количество строк в массиве =  ");
int n = Request("Введите количество столбцов в массиве = ");
int minValue = Request("Введите минимальное целое значение элемента массива = ");
int maxValue = Request("Введите максимальное целое значение элемента массива = ");
int[,] resMatrix = GetMatrix(m,n,minValue,maxValue);
PrintMatrix(resMatrix);
SumOfDiagonalNum(resMatrix);

