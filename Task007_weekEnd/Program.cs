void daysOfWeek(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,8);
    }
}

int[] arr = new int[7];
daysOfWeek(arr);
for (int i = 0; i < arr.Length; i++)
{
    int date = arr[i];
    if (date < 6)
    {
        Console.WriteLine(arr [i] + " Соберись! Сегодня рабочий день!");
    }
    else if (date == 6)
    {
        Console.WriteLine(arr [i] + " Ура! Сегодня Выходной!");
    }
    else
    {
        Console.WriteLine(arr[i] + " Ура! Сегодня снова выходной!");
    }
}


