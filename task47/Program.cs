// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            someArray[i, j] = new Random().Next(-10, 10) ;
        }
    }
    return someArray;
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            Console.Write($" {someArray[i, j]} ".PadLeft(6));
        }
        Console.WriteLine();
    }
}
