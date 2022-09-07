// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int min = ReadInt($"Введите значение от: ");
int max = ReadInt($"Введите значение до: ");
Console.Write($"Сумма наутральных чисел от {min} до {max} -> {FindSum(min, max)}");

int FindSum(int min, int max)
{
    int sum = 0;
    if (min == max)
        return sum += max;
    else if (min < max)
    {
        sum += min;
        min++;
        sum += FindSum(min,max);
    }
    return sum;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
