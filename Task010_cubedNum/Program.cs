Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
   Console.Write(Math.Pow(i,3)+ "\t"); 
}