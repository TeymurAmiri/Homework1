int m = NameInt($"Введите количество строк -> ");
int n = NameInt($"Введите количество столбцов -> ");
double[,] array = new double[m, n];
Console.WriteLine();
RandomFillArray(array);

void RandomFillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            new Random().NextDouble();
            array[i,j] = new Random().Next(-10, 11) + new Random().NextDouble();
            Console.Write(Math.Round(array[i, j], 1) + " ");
        } 
        Console.WriteLine();
    }
}

int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}