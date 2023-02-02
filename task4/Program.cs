// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите любое число, отличающееся от 1: ");
int N = int.Parse(Console.ReadLine());
int start = 1;
if (N > 1)
{
    while (start <= N)
    {
        if (start % 2 == 0) Console.Write(start + ", ");
        start++;
    }
}
if(N <=1) Console.WriteLine("ошибка");