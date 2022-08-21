// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int size = NumberMassive("Введите количество элементов массива: ");
int[] array = new int[size];
FillArray(array);
Console.WriteLine();
EvenNumber(array);


void EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }        
    }
    Console.Write($"Количество четных чисел в массиве -> {count}");  
}

void FillArray(int[] array)
{
    Console.Write($"Массив состоящий из {size} элементов -> ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
}

int NumberMassive(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}