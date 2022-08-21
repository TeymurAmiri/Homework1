// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = NumberMassive("Введите количество элменетов массива: ");
int[] array = new int[size];
FillArray(array);
Console.WriteLine();
OddNumbers(array);

void OddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += array[i];
        }
    }
    Console.Write($"Сумма всех элементов массива, стоящих на нечетных позициях -> {sum}");
}

int NumberMassive(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Console.Write($"Массив из {size} элементов -> ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
}