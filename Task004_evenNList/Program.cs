Console.WriteLine("Введите число: ");
int endList = Convert.ToInt32(Console.ReadLine());

/*while (number <= endList) //Введенное пользователем число включаем в перечень!
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number = number + 1;  
}*/

for (int number = 1; number < endList; number++)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
}

