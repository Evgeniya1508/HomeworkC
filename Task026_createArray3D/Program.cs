/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int Request(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
void PrintArray3D (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write($"{array3D[i,j,k]}({i},{j},{k})  ");
      }
      Console.WriteLine();
    }
  }
}
int[,,] CreateArray3D(int x, int y, int z)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k=0;
            while(k<result.GetLength(2))
            {
                int element = new Random().Next(10,99);
                if(FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}
bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == el)
                return true;
            }
        }
    }
    return false;
}

Console.WriteLine($"Введите размер трехмерного массива X x Y x Z: ");
int x = Request("Введите X: ");
int y = Request("Введите Y: ");
int z = Request("Введите Z: ");
int[,,] array3D = CreateArray3D(x, y, z);
PrintArray3D(array3D);

