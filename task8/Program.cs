//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

if ((1<N)) 
{
   while (i <= N)
   {
    Console.Write($"{i} ");
    i+=2;
   } 
}
else
{
 Console.WriteLine("Введите число большее 1!!!");   
}
