//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());

if ((numberA % 2) == 0)
{
    Console.WriteLine($"{numberA} является четным");
}
else
{
   Console.WriteLine($"{numberA} не является четным ");
}
