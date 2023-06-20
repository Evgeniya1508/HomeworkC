/*Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int Request(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NaturalElementsSum(int m, int n)
{
    if (m == n) return n;
    return m + NaturalElementsSum(m + 1, n);
}
int m = Request("Введите целое положительное число M  ");
int n = Request("Введите целое положительное число N  ");
if (m > n || m <= 0 || n <= 0)
{
    Console.WriteLine("Ошибка, повторите ввод чисел, учтите, что M должно быть больше N, также M и N больше 0!!!");
    return;
}
int result = NaturalElementsSum(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {result}");