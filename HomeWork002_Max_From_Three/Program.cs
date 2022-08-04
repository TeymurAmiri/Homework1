Console.WriteLine("Условия задачи: ");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

Console.Write("Задайте первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Задайте третье число: ");
int c = Convert.ToInt32(Console.ReadLine()); 
int max = a;

if(b > a && b > c)
{
    max = b;
}
if(c > b && c > a)
{ 
    max = c; 
}
Console.WriteLine("Максимумом является число " + max);

