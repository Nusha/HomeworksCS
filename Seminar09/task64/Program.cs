// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();


void NumberSet(int n)
{
    if (n == 0) return;
    if (n == 1) Console.Write($"{n} ");
    else
    {
     Console.Write($"{n}, ");   
    }
    
    NumberSet(n-1);
}

Console.Write("Введите целое положительное число N: ");
int n = Int32.Parse(Console.ReadLine()!);
if (n<=0)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else
{
Console.Write($"N = {n} -> ");
NumberSet(n);
Console.WriteLine();
}