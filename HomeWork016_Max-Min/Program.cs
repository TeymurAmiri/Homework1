/*
int size = NameNumber("Введите количество элементов массива: ");
int[] array = new int[size];
FillArray(array);

int max = array[1];
int min = array[0];
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if(array[i] < min)
    {
        min = array[i];
    }
}
Console.Write($"Разница между максимальным и минимальным элеменами -> {max - min}");


int NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Console.Write($"Массив из {size} элементов -> ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 51);
        Console.Write(array[i] + " ");
    }
   
}
*/

int size = NameNumber("Введите количество элементов массива: ");
double[] array = new double[size];
FillArray(array);
Console.WriteLine();
MaxMin(array);


void MaxMin(double[] array)
{     
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.Write($"Разница между максимальным и минимальным элементами -> {max - min}");    
}

int NameNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    Console.Write($"Массив из {size} элементов -> ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
        Console.Write(array[i] + " ");
    }
   
}