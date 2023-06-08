//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь
int Request (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] CreateUserArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите элемент массива {i+1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}
int CountNumOverZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}


int size = Request("Введите желаемое количество целых чисел");
int[] numbers = CreateUserArray(size);
int countNum = CountNumOverZero(numbers);
Console.WriteLine($"В массиве: [{String.Join("; ", numbers)}]  присутствует {countNum} чисел больше 0.");

