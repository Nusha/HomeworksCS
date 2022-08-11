Console.Clear();
Console.Write("Введите первое число (любое целое):  ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (любое целое):  ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число (любое целое):  ");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA > max) max = numA;
if (numB > max) max = numB;    
if (numC > max) max = numC;

Console.WriteLine($"{numA}, {numB}, {numC} -> {max}");