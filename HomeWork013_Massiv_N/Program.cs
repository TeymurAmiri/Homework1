int NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void RandomArray(int a)
{
    Console.Write($"Массив из {a} элементов -> ");
    int[] array = new int[a];
    for(int i = 0; i < a; i++)
    {
        array[i] = new Random().Next(0, 100);
        Console.Write(array[i] + " ");
    }
}

int a = NameNumber("Введите количество элементов массива: ");
RandomArray(a);
 

