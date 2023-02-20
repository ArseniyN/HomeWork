// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8]; 
GetArray(array); 
PrintArray(array);

void GetArray(int[] arr) 
{
    for (int i = 0; i < 8; i++) { arr[i] = new Random().Next(0, 10); }
}
void PrintArray(int[] arr) 
{
    for (int i = 0; i < 8; i++) { Console.Write($"{arr[i]}, "); }
}
