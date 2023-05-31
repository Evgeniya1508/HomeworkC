Console.WriteLine("Введите любое целое число (А)");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое целое число (B)");
int numB = Convert.ToInt32(Console.ReadLine());
double result = 1;
for (int i = 1; i <= numB; i++)
{
    result = Math.Pow(numA,i);
}
Console.WriteLine($"Число А, возведенное в {numB} степень  равно {result}.");

