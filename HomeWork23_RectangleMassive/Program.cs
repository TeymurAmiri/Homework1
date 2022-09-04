
int rows = NameInt("Введите количество строк: ");
int columns = NameInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
Console.WriteLine();
Console.WriteLine($"Полученный массив: ");
FillArrayRandom(array);
PrintArray(array);

Console.WriteLine();

int minIndex = 0;
int sum = SumNumbers(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = SumNumbers(array, i);
    if (sum > temp)
    {
        sum = temp;
        minIndex = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: \n1)Cтрока {minIndex + 1}\n2)Сумма элементов данной строки -> {sum}");

Console.ReadKey();
int SumNumbers(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
