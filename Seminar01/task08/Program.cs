Console.Clear();
Console.Write("Введите любое целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
    {
    Console.WriteLine("Необходимо ввести любое положительное число от 1");
    }
else {
int num = n;
if (n % 2 != 0)
    {
    n = n - 1;
    }
Console.Write($"{num} -> ");
while (n >= 1)
    {
    Console.Write($"{n},");
    n = n - 2;    
    }
Console.WriteLine();
}