/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int Request(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string NaturalNumbersInterval(int start, int end)
{
    if(end == start) return end.ToString();
    return start + ", "  + NaturalNumbersInterval(start - 1, end);

}
int N = Request("Введите любое целое положительное число   ");
if (N <= 0)
{
    Console.WriteLine("Ошибка, введите только целое ПОЛОЖИТЕЛЬНОЕ число");
    return;
}
Console.WriteLine($"Последовательность '{NaturalNumbersInterval(N, 1)}'");