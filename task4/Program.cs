// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numberC = Convert.ToInt32(Console.ReadLine());

var max = numberA;

if (max < numberB)
{
    max = numberB;
}
if (max  < numberC)
{
    max = numberC;
}

Console.WriteLine($"Максимальное значение {max}");