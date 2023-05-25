Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int secSymb = number / 10 % 10;
Console.WriteLine("Вторая цифра в веденном Вами числе - " + secSymb);
