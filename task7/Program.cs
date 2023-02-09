// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if ((num == 6 || num ==7))
{
    Console.WriteLine("Сегодня выходной день.");
}
if ((num > 0 & num < 6))
{
    Console.WriteLine("Сегодня будний день.");
}
if ((num < 0 || num > 7)) Console.WriteLine("В неделе семь дней.");