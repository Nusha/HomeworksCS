// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет. 
// Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int input = num;
num = Math.Abs(num);
int n3 = 0;
while (num > 999)
    {
    num=num/10; 
    }
if (num < 100)
    {
        Console.WriteLine($"{input} -> третьей цифры нет");
    }
else
    {
        n3=num%10;
        Console.WriteLine($"{input} -> {n3}");
    }