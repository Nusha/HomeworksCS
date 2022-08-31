// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

double[,] CreatMatrixDoubleRandom(int row, int col)
{
    if (row < 2 || col < 2)
    {
        Console.WriteLine("Массив не является двумерным");
        return null!;
    }
    else
    {
        double[,] matrix = new double[row, col];
        Random rnd = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(rnd.Next(-9, 9) + rnd.NextDouble(), 1);

            }
        }
        return matrix;
    }
}

void PrintMatrix(double[,] matrix)
{
    if (matrix != null)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("[");

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}|");
                else Console.Write($"{matrix[i, j],5}");


            }
            Console.WriteLine("]");

        }
        Console.WriteLine();
    }
    else Console.WriteLine("Не передано значение двумерного масива");
}

void PrintMatrixValue(double[,] matrix, int r, int c)
{
    if (matrix != null)
    {
        Console.WriteLine(r > matrix.GetLength(0) || r < 1 || c > matrix.GetLength(1) || c < 1 ? $"{r}, {c} -> Такого элемента нет" :
        $"{r}, {c} -> {matrix.GetValue(r - 1, c - 1)}");
    }
    else Console.WriteLine("Не передано значение двумерного масива");
}

Console.Clear();

Console.Write ("Введите количество рядов в массиве 'M': ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество колонок в массиве 'N': ");
int n = Int32.Parse(Console.ReadLine()!);

double [,] matrix = CreatMatrixDoubleRandom(m,n);

PrintMatrix(matrix);

Console.Write ("Введите ряд массива: ");
int r = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите колонку  массива: ");
int c = Int32.Parse(Console.ReadLine()!);

PrintMatrixValue(matrix, r, c);
