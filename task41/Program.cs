// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Clear();
Console.Write("Введите числа: "); 
string input = Console.ReadLine(); 
string[] subs = input.Split(); 
int[] array = new int[subs.Length]; 
ConvertStringToInt(subs); 
PrintintArray(array); 
Console.WriteLine($" -> {FindPositiveNums(array)}"); 


int[] ConvertStringToInt(string[] someArray)
{
    for (int i = 0; i < subs.Length; i++) array[i] = int.Parse(subs[i]); 
    return array;
}


int FindPositiveNums(int[] someArray)
{
    int counter = 0;
    foreach (int element in array) if (element > 0) counter++; 
    return counter;
}


void PrintintArray(int[] someArray)
{
    for (int i = 0; i < someArray.Length - 1; i++) Console.Write($"{someArray[i]}, ");
    Console.Write($"{someArray[someArray.Length - 1]}");
}