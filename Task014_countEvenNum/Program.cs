//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2 
int Request(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(99,1000);
    }
    return resultArray;
}
int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}

int size = Request("Введите желаемое количество элементов в одномерном массиве ");
int[] array = GetArray(size);
int evenNum = CountEvenNum(array);
Console.Write($"В массиве: [{String.Join("; ", array)}] {evenNum} четных чис.");



