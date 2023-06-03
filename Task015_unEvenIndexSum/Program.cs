//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int Request(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int CountSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int size = Request("Введите желаемое количество элементов в одномерном массиве ");
int minValue = Request("Введите минимальное значение элемента массива");
int maxValue = Request("Введите максимальное значение элемента массива");
int[] array = GetArray(size,minValue,maxValue);
int unEvenSum = CountSum(array);
Console.Write($"Cумма элементов, стоящих на нечётных позициях, в массиве: [{String.Join("; ", array)}] составляет: {unEvenSum}");