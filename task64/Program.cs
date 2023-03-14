// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write($"N = {N} -> ");
OutputOfNumber(N);
Console.WriteLine();
void OutputOfNumber(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        OutputOfNumber(n - 1);
    }
}
