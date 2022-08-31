// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double [,] CreatMatrixDoubleRandom(int row, int col)
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

void PrintMatrix (double [,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5}|"); 
            else Console.Write($"{matrix[i,j], 5}");
            
           
        }
        Console.WriteLine("]");
       
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write ("Введите количество рядов в массиве 'M': ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество колонок в массиве 'N': ");
int n = Int32.Parse(Console.ReadLine()!);


double [,] matrix = CreatMatrixDoubleRandom(m,n);
PrintMatrix(matrix);

