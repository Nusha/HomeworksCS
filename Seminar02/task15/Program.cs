// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите порядковый номер дня недели (от 1 до 7): ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday < 1 || weekday > 7)
{
    Console.WriteLine($"{weekday} вне диапазона от 1 до 7");
}
else if (weekday == 6 || weekday == 7)
{
    Console.WriteLine($"{weekday} -> да");
}
else
{
    Console.WriteLine($"{weekday} -> нет");
}
