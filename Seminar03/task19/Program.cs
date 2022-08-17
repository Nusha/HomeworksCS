//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение 1.
// Громоздкое - сначала невнимательно прочитал задачу, и сделал для числа без ограничения по разрядам.
// Потом подумал, что если обернуть в методы - будет более универсальным. 
//***

long ReverseNum(long number)
{
    long a = Math.Abs(number);
    long b = 0;
    long c = 0;
    while (a > 0)
    {
        b = a % 10;
        c = c * 10 + b;
        a = a / 10;
    }
    if (number < 0) c = c * -1;
    return c;
}

bool CheckPalindr(long number)
{
    long a = Math.Abs(number);
    bool pali = a == Math.Abs(ReverseNum(number)) ? true : false;
    return pali;
}


Console.Clear();
Console.Write("Введите целое число: ");
long num = Convert.ToInt64(Console.ReadLine());
if (num / 100000 != 0 || num / 10000 == 0)
{
    Console.WriteLine($"Число {num} не является пятизначным");
}

else
{
    if (CheckPalindr(num) == true)
    {
        Console.WriteLine($"{num} -> Да");
    }
    else
    {
        Console.WriteLine($"{num} -> Нет");
    }
}

//***


// Решение 2
// Решение для проверки пятизначного числа, хотел попробовать через тернарный оператор, 
// правда используется переменная строкового типа для вывода.
//***

// Console.Clear();
// Console.Write("Введите пятизначное целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 100000 != 0 || num / 10000 == 0) Console.WriteLine($"Число {num} не является пятизначным");
// else
// {
//     string flag = num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10 ? "Да" : "Нет";
//     Console.WriteLine($"{num} -> {flag}");
// }

//***


