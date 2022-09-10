// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}


Console.Write("Введите целое положительное число M: ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write("Введите целое положительное число N: ");
int n = Int32.Parse(Console.ReadLine()!);

if (m < 0 || n < 0) Console.WriteLine("Введены отрицательные(отрицательное) числа(число)");
else
{
    Console.Write($"m = {m}, n = {n} -> A(m,n) = ");

    int result = Ackermann(m, n);
    Console.Write(result);
    Console.WriteLine();
}