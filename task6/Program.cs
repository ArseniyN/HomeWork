// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет


Console.Write("Введи число: ");
int num = int.Parse(Console.ReadLine());
string numInText = Convert.ToString(num);
if (numInText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + numInText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}