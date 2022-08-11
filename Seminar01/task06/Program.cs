Console.Clear();
Console.Write("Введите любое целое число:  ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    {
        Console.WriteLine($"{num} -> да");
    }
else
    {
        Console.WriteLine($"{num} -> нет");
        }