// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreatMatrixIntRandom(int row, int col)
{
    if (row < 2 || col < 2)
    {
        Console.WriteLine("Массив не является двумерным");
        return null!;
    }
    else
    {
        int[,] matrix = new int[row, col];
        Random rnd = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(0, 9);

            }
        }
        return matrix;
    }
}

void PrintMatrix(int[,] matrix)
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

void SortMatrixBubble(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int t = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = t;
                }
            }
        }
    }
}

Console.Clear();

Console.Write ("Введите количество рядов в массиве 'M': ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество колонок в массиве 'N': ");
int n = Int32.Parse(Console.ReadLine()!);

int [,] matrix = CreatMatrixIntRandom(m,n);
PrintMatrix(matrix);
SortMatrixBubble(matrix);
PrintMatrix(matrix);










