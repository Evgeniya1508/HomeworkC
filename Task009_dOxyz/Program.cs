Console.WriteLine("Введите координаты первой точки по оси x");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси z");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по оси x");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси z");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между двумя, заданными Вами точками в 3D пространстве, равно: {Math.Round(d,2)}");