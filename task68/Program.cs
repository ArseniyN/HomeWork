// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите число m: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int numberN = int.Parse(Console.ReadLine()!);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m, n) = {AckermannFunction(numberM, numberN)}");
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}