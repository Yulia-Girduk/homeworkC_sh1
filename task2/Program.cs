//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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