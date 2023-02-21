// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();
Console.Write("Введите номер строки элемента: ");
int firstIndex = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int secondIndex = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(4, 4); 
PrintBigArray(array);
FindElement(array);

int[,] GetArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
        }
    }
    return someArray;
}

void PrintBigArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($" {someArray[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] someArray)
{
    if (firstIndex < 0 || firstIndex >= someArray.GetLength(0) || secondIndex < 0 || secondIndex >= someArray.GetLength(1))
    {
        Console.WriteLine($"По данному индексу [{firstIndex}, {secondIndex}] нет элемента.");
        return;
    }
    else Console.WriteLine($"По данному индексу [{firstIndex}, {secondIndex}] находится элемент {someArray[firstIndex, secondIndex]}.");
}
