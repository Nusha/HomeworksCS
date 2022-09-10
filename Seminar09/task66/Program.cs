// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int SumElMn(int m, int n)
{
    if (m == n) return n;
    return m = m + SumElMn(m + 1, n);
}

Console.Write("Введите целое положительное число M: ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите целое положительное число N: ");
int n = Int32.Parse(Console.ReadLine()!);

Console.Write($"M = {m}; N = {n} -> ");
if (m > n)
{
    int t = 0;
    t = m;
    m = n;
    n = t;
}

int result = SumElMn(m, n);
Console.Write(result);
Console.WriteLine();
