void randomNum(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1,100);
    }
}
int size = 8;
int[] arr = new int[size];
randomNum(arr);
Console.WriteLine($"Maccив: [{String.Join("; ", arr)}]");
