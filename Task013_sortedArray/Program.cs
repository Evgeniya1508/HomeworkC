int Request(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int [] GetArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10,100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}
void SortedArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
           if (array[j] > array[j + 1])
           {
               (array[j], array[j + 1]) = (array[j + 1], array[j]);
           }
        } 
    }
}
int n = Request("Введите размер массива:");
int [] arr = GetArray(n);
Console.Write("Исходный массив: ");
PrintArray(arr);
SortedArray(arr);
Console.Write("Отсортированный массив ");
PrintArray(arr);


