// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine();
FindSmallRow(array);
int[,] FillArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns + 1];
    int sum = 0;
    for (int i = 0; i < someRows; i++)
    {
        for (int j = 0; j < someColumns; j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
            sum = sum + someArray[i, j];
        }
        someArray[i, someColumns] = sum;
        sum = 0; 
    }
    return someArray;
}
void FindSmallRow(int[,] someArray)
{
    int minSum = someArray[0, someArray.GetLength(1) - 1];
    int indexOfMinRow = 0; 
    for (int i = 1; i < someArray.GetLength(0); i++)
    {
        if (someArray[i, someArray.GetLength(1) - 1] < minSum)
        {
            minSum = someArray[i, someArray.GetLength(1) - 1];
            indexOfMinRow = i;
        }
    }
    Console.WriteLine($"Строка с индексом [{indexOfMinRow}], является строкой с наименьшей суммой элементов:");
    for (int j = 0; j < someArray.GetLength(1) - 1; j++)
        Console.Write($"{someArray[indexOfMinRow, j]}  ");
    Console.WriteLine();
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1) - 1; j++)
        {
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine($"({someArray[i, someArray.GetLength(1) - 1]})");
    }
}

