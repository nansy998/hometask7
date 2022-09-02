static void Main(string[] args)
{
    int[,] mas = new int[3, 3] { { 1, 2, 3 }, { 3, 5, 7 }, { 5, 6, 1 } };

    for (int i = 0; i < 3; i++)
    {
        int srAr = 0;
        int ColChetn = 0;
        for (int t = 0; t < 3; t++)
        {
            srAr += mas[t, i];
            ColChetn += (mas[t, i] % 2 == 0) ? 1 : 0;
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr / 3}");
    }
}