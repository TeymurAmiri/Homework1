// Задача №58  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int rows = NameInt("Введите количество строк: ");
int columns = NameInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
FillArrayRandom(array);
FillArrayRandom(secondArray);
Console.WriteLine($"Первый массив: ");
PrintArray(array);
Console.WriteLine($"Второй массив: ");
PrintArray(secondArray);

int[,] thirdArray = new int[rows, columns];

if(array.GetLength(0) != secondArray.GetLength(1))
{
    Console.Write($"Умножение нельзя производить!");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        thirdArray[i,j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            thirdArray[i,j] += array[i,k] * secondArray[k,j];
        }
    }
}
Console.WriteLine($"Результирующая матрица: ");
PrintArray(thirdArray);

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
            array[i, j] = new Random().Next(1, 5);
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