// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int row = NameInt($"Введите количество строк: ");
int columns = NameInt($"Введите количество столбцов: ");
int[,] array = new int[row, columns];

int digit = 1;
int i = 0;
int j = 0;

// 1(0;0) 2(0;1) 3(0;2) 4(0;3)
//12(1;0)13(1;1)14(1;2) 5(1;3)
//11(2;0)       15(2;2) 6(2;3)
//10(3;0) 9(3;1) 8(3;2) 7(3;3)

while (digit <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = digit;
  digit++;
  if(i <= j + 1 && i + j < array.GetLength(1) - 1)
  {
    j++;
  }
  else if(i < j && i + j >= array.GetLength(0) -1)
  {
    i++;
  }
  else if(i >= j && i + j > array.GetLength(1) -1)
  {
    j--;
  }
  else 
  i--;
}
Console.WriteLine();
Console.WriteLine($"Массив 4 на 4: ");
PrintArrayWithNull(array);
Console.ReadKey();

void PrintArrayWithNull(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if(array[i,j] < 10)
            {
                Console.Write($"{0}");
                Console.Write(array[i, j] + " ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }

        }
        Console.WriteLine();
    }
}


int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
