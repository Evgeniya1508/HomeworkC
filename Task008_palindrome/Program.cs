Console.WriteLine("Введите любое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int fNum = number / 10000;
int sNum = number / 1000 % 10;
int forNum = number / 10 % 10;
int fifNum = number % 10;

if (number < 10000)
{
    Console.WriteLine("Ошибка! Введите ТОЛЬКО 5-значное число!");
}
else if (number > 99999)
{
    Console.WriteLine("Ошибка! Введите ТОЛЬКО 5-значное число!");
}
else if(fNum == fifNum && sNum == forNum)
{
    Console.WriteLine("Введенное Вами число является ПАЛИНДРОМОМ!");
}
else
{
    Console.WriteLine("Введенное Вами число палиндромом НЕ является!");
}



