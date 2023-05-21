Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Введенное Вами число " + number + " является ЧЕТНЫМ");
}
else
{
    Console.WriteLine("Введенное Вами число " + number + " является НЕЧЕТНЫМ");
}