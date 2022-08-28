// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindInterSection(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые не совпадают");
        return null!;
    }
    else
    {
        double[] res = new double[2];
        res[0] = (b1 - b2) / (k2 - k1);
        res[1] = (k2 * b1 - k1 * b2) / (k2 - k1);

        return res;
    }
}

void PrintArray8(double[] arr)
{
    if (arr != null)
    {
        Console.Write("(");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($" {Math.Round(arr[i], 1)},");
        }
        Console.Write(")");
    }
}

Console.Clear();
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] xy = FindInterSection(b1,k1,b2,k2);


if (xy != null)
{
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
    PrintArray8(xy);
    Console.WriteLine();
}
else Console.WriteLine("Нет значения");