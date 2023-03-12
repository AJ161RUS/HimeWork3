/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 
                                             */
/* int N;
int i = 1;
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!, out N);
while ( i <= N)
i = i % 2; 


Console.WriteLine ($"{i}"); */


int n = 2;
int N;

Console.WriteLine("Введите число ");
int.TryParse(Console.ReadLine()!, out N);
if (n <= N)
{
    while (n <= N)
    {
        Console.Write($"{n} " );
        n += 2;
    }
}
else Console.WriteLine($"неверный ввод");