// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Задайте количество чисел в массиве: ");
int size = int.Parse(Console.ReadLine()); 
int[] array = new int[size];
int counter = 0; 
array = GetArray(size);
PrintArray(array); 
Console.WriteLine($"Количество четных чисел в массиве - {counter}"); 

int[] GetArray(int i) 
{
    for (i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000); 
        if (array[i] % 2 == 0) counter++; 
    }
    return array;
}
void PrintArray(int[] array) 
{
    for (int a = 0; a < size - 1; a++) Console.Write($"{array[a]}, ");
    Console.WriteLine($"{array[size - 1]}");
}