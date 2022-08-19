// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите любое целое (не менее двух разрядов) число: ");
long number = Convert.ToInt64(Console.ReadLine());
long CalculateDigitSumInNum(long num)
{
    num = Math.Abs(num);
    if (num < 10) Console.WriteLine($"Число {num} не является многоразрядным, нечего считать.");
    long a = num;
    long sum = 0;
    int count = 1;
    while (a / 10 != 0)
    {
        a = a / 10;
        count++;

        for (int i = 0; i <= count; i++)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
    }
    return sum;
}
long sum = CalculateDigitSumInNum(number);
if (sum == 0) return;
Console.WriteLine($"{number} -> {sum}");
