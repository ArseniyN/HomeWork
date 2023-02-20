// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Задайте количество чисел в массиве: ");
int size = int.Parse(Console.ReadLine()); 
int[] array = new int[size]; 
int sum = 0;

array = GetArray(size); 
SumNum(array); 
PrintArray(array); 
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");

int[] GetArray(int a) 
{
    for (a = 0; a < size; a++) array[a] = new Random().Next(-99, 100); 
    return array;
}

int SumNum(int[] arr) 
{
    for (int a = 0; a < size; a++)
    {
        if (a % 2 == 0) sum += array[a];
    }
    return sum;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < size - 1; i++) Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[size - 1]}");
}