int row = NameInt($"Введите количество строк -> ");
int columns = NameInt($"Введите количество столбцов -> ");
int[,] array = new int[row, columns];
FillArray(array);
NenavigyProgrammirovanie(array);

void NenavigyProgrammirovanie(int[,] array)
{
    Console.Write($"Среднее арифметическое каждого столбца по очереди -> ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        sum = sum / array.GetLength(0);
        Console.Write($"{Math.Round(sum, 1)}; ");
    }
}

void FillArray(int[,] array)
{
    Console.Write("Полученный массив: ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}