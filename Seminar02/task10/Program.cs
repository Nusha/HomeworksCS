// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа. Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите любое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n2 = 0;
int input = num;
num = Math.Abs(num);
if (num >= 1000 || num < 100)
    {
       
     Console.WriteLine("Вы ввели не трёхзначное число.");
    }
else 
    {
    n2 = num%100/10;
    Console.WriteLine($"{input} -> {n2}");

    }
