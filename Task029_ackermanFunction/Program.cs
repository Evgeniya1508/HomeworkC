/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int Request(string message) 
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}
int AckFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckFunction(m - 1, 1);
  else return AckFunction(m - 1, AckFunction(m, n - 1));
}
int m = Request("Введите неотрицательное число m: ");
int n = Request("Введите неотрицательное число n: ");
if (m < 0 || n < 00)
{
    Console.WriteLine("Ощибка! Введите 2 НЕОТРИЦАТЕЛЬНЫХ ЧИСЛА!!!");
    return;
}
int functionAckerman = AckFunction(m, n);
Console.Write($"Функция Аккермана = {functionAckerman} ");
