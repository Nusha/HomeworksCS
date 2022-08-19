// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите целое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0) Console.WriteLine($"{b} является отрицательным числом.");
else
{
    
     int d = a;
    for (int count = 1; count < b; count++) { d = d * a; }

    
    // Решение через while
    // int count = 1;
    // while (count < b) {d = d * a; count++;}
   


    Console.WriteLine($"{a}, {b} -> {d}");
}
