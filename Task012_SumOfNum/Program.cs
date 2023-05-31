Console.WriteLine("Введите любое целое положительное число");
int number = int.Parse(Console.ReadLine());
int sumOfNum = 0;
int element = 0;
if (number > 0)
{
    while (number > 0)
    {
    element = number % 10;
    sumOfNum = sumOfNum + element;
    number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в заданном Вами числе составляет {sumOfNum}.");
}
else
{
    Console.WriteLine($"Ошибка! Ввведенное Вами число {number} является отрицательным! Введите только положительное число!!!");
}

    

