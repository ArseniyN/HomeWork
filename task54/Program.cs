// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns);
PrintArray(array);
Console.WriteLine("Массив с упорядоченными по убыванию строками:");
int[,] orderedArray = OrderingOfRows(array);
PrintArray(orderedArray);
int[,] FillArray(int someRows, int someColumns)
{
    int[,] someArray = new int[someRows, someColumns];
    for (int i = 0; i < someRows; i++)
    {
        for (int j = 0; j < someColumns; j++)
        {
            someArray[i, j] = new Random().Next(0, 10);
        }
    }
    return someArray;
}

int[,] OrderingOfRows(int[,] someArray)
{
    for (int i = 0; i < someArray.GetLength(0); i++) 
    {
        for (int j = 0; j < someArray.GetLength(1); j++) 
        {
            for (int k = j + 1; k < someArray.GetLength(1); k++) 
            {
                if (someArray[i, k] > someArray[i, j]) 
                {
                    int temp = someArray[i, j];
                    someArray[i, j] = someArray[i, k];
                    someArray[i, k] = temp;
                    temp = 0; 
                }
            }
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
            Console.Write($"{someArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}