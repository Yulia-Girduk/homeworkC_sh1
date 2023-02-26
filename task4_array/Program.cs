// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int[] arrayA;

Console.Write("Введите длину массива ");
int n = Convert.ToInt32(Console.ReadLine());

arrayA = new int[n];
//Console.WriteLine(arrayA.Length);

for (int i = 0; i < arrayA.Length; i++)
{
    Console.Write("Введите значения элементов массива ");
    arrayA[i] = Convert.ToInt32(Console.ReadLine());
}

var max = arrayA[0];

for (int i = 1; i < arrayA.Length; i++)
{
   if (max < arrayA[i])
   {
    max = arrayA[i];
   }
}

Console.WriteLine($"Максимальное значении {max}");