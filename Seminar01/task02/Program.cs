Console.Clear();
Console.Write("Введите любое целое число А:  ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число B:  ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
    {
        Console.WriteLine ($"A = {A}; B = {B} -> max = {A}");
    }
else
    {
        Console.WriteLine ($"A = {A}; B = {B} -> max = {B}");
    }