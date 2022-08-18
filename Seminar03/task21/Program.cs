// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Dist3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return distance;
}
Console.Clear();
Console.Write($"Введите координату Х для точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату Y для точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату Z для точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату Х для точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату Y для точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату Z для точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Dist3D(x1,x2,y1,y2,z1,z2);
result = Math.Round(result, 2);
Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {result}");