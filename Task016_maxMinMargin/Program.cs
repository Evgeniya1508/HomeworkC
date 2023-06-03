//Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int Request(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double[] GetArray(int size)
{
    double[] resultArray = new double[size];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble()*100,2);
    }
    return resultArray;
}
double CountMargin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double margin = max - min;
    return margin;
}

int size = Request("Введите желаемое количество элементов в одномерном массиве ");
double[] array = GetArray(size);
double marginMaxMin = CountMargin(array);
Console.WriteLine($"Разница между макс и мин элементами в массиве [{String.Join("; ", array)}] = {marginMaxMin}");

/*double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
double margin = max - min;*/ 
//Console.WriteLine($"Максимальный элемент {max} минимальный {min}");