// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int numberB = Convert.ToInt32(Console.ReadLine());



if (numberA < numberB)
{
    Console.WriteLine($"{numberB} - большее, {numberA} - меньшее");
}
else if (numberB < numberA )
{
    Console.WriteLine($"{numberA} - большее, {numberB} - меньшее");
}
else
{
    Console.WriteLine($"{numberB} равно {numberA}");
}