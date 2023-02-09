// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1






Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int a1 = num % 100;
    int result = a1 / 10;
    Console.WriteLine($"Ввели число {num}. Результат удаления первой и третьей цифры: {result}");
}

