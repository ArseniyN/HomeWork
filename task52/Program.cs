// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintBigArray(array);
double[] averageArray = FindAverageOfColumns(array);
PrintSmallArray(averageArray);
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

double[] FindAverageOfColumns(int[,] someArray)
{
    double[] average = new double[someArray.GetLength(1)];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            average[j] += someArray[i, j];
        }
    }
    for (int i = 0; i < average.Length; i++)
    {
        average[i] = Math.Round(average[i] / rows, 1);
    }
    return average;
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

void PrintSmallArray(double[] someArray)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    for (int i = 0; i < someArray.Length; i++)
    {
        Console.Write($" {someArray[i]}".PadRight(3));
    }
    Console.WriteLine();
}