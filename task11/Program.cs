// Написать цикл, который принимает на вохд два числа (A и B) и возводит число А в натуральную степень В
// 3, 5 -> 243 (3 в пятой степени)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} в степени {B} равно {Square(A, B)}.");

int Square(int firstNum, int secondNum) 
{
    int result = A; 
    for (int i = 1; i < B; i++) { result = result * A; } 
    return result;
}