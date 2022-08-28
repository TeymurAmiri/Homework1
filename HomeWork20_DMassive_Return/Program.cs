int row = NameInt($"Введите количество строк -> ");
int columns = NameInt($"Введите количество столбцов -> ");
int[,] array = new int[row, columns];
FillArray(array);
int a = NameInt($"Введите позицию элемента массива -> ");
FindElement(array);

void FindElement(int[,] array)
{
    if (a / 10 >= array.GetLength(0) || a % 10 >= array.GetLength(1))
    {
        Console.Write($"Элемента с такой позицией не существует");
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a / 10 == i && a % 10 == j)
            {
                Console.Write($"Элемент с такой позицией присутствует в массиве и равен {array[i, j]}");
            }
        }

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