// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите число от 1: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1)
{   Console.WriteLine("Число        Куб");

    for (int i = 1; i <= n;)
    {
        Console.WriteLine($" {i}     | {i * i * i} ");
        Console.WriteLine("_______________________");
        i++;
    }
}
else Console.WriteLine("Число меньше 1.");