// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.Write($"M = {numberM}; N = {numberN} -> ");
int temp = 0;
if (numberM > numberN)
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}
int sum = 0;
sum = FindSumBetweenNumbers(numberM, numberN);
Console.WriteLine(sum);
int FindSumBetweenNumbers(int m, int n)
{
    if (n >= m)
    {
        sum += n;
        FindSumBetweenNumbers(m, n - 1);
    }
    return sum;
}