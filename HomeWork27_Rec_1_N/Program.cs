// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

int number = ReadInt($"Введите натуральное число: ");
Console.Write($"Промежуток от {number} до 1 -> ");
FromDigit(number);

void FromDigit(int number)
{
    if (number == 1)
        Console.Write($"{number}.");
    else
    {
        Console.Write($"{number}, ");
        FromDigit(number - 1);
    } 
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}