// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Задайте количество чисел в массиве: ");
int size = int.Parse(Console.ReadLine()); 
int[] array = new int[size]; 
int minValue = 100; 
int maxValue = -100;
int result = 0;

array = GetArray(size);
PrintArray(array);
DiffMaxMin(array);
Console.WriteLine($"Минимальное число в массиве: {minValue}");
Console.WriteLine($"Максимальное число в массиве: {maxValue}");
Console.WriteLine($"Разнница между максимальным и минимальным числами в массиве: {result}");

int[] GetArray(int a)
{
    for (int i = 0; i < size; i++) array[i] = new Random().Next(-100 , 100) ; 
    return array;
}

void PrintArray(int[] arr) 
{
    Console.WriteLine("Массив:");
    for (int j = 0; j < size; j++) Console.WriteLine(($"{array[j]}"));
}

int DiffMaxMin(int[] y) 
{
    foreach (int i in array)
    {
        if (i < minValue) minValue = i; 
        if (i > maxValue) maxValue = i;
    }
    return result = Math.Abs(maxValue - minValue); 
}
