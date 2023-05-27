Console.WriteLine("Введите первое число: ");
int firNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int thirdNumber = int.Parse(Console.ReadLine());
if (firNumber > secNumber)
{
    Console.WriteLine("Максимальное число: " +  firNumber);
}
else if (secNumber < thirdNumber)
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + secNumber);
}