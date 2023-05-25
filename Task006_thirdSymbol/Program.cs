Console.WriteLine("Введите любое число до 9999");
int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третья цифра в введенном Вами числе ОТСУТСТВУЕТ");
}
else if (number < 1000)
{
    int thirdSymb = number % 10;
    Console.WriteLine("Третья цифра в введенном Вами числе - " + thirdSymb);
}
else
{
    int thirdSymb = number / 10 % 10;
    Console.WriteLine("Третья цифра в введенном Вами числе - " + thirdSymb);
}