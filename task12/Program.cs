// Программа принимает на вход число и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите любое число: ");
int N = Math.Abs(int.Parse(Console.ReadLine())); 
Console.WriteLine($"Сумма всех цифр этого числа = {GetSum(N)}"); 

int GetSum(int i) 
{
    int sum = 0;
    for (;i > 0; i = i / 10) { sum = sum + i % 10; }
    return sum;
}