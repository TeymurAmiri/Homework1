
int rows = NameInt("Введите количество строк: ");
int columns = NameInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
FillArrayRandom(array);
Console.WriteLine($"Заданный массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Отсортированный массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if(array[i,k] < array[i,k+1])
            {
                int temp = array[i,k];
                array[i,k] = array[i,k+1];
                array[i,k+1] = temp;
            }
        }
    }
}
PrintArray(array);
Console.ReadKey();


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
