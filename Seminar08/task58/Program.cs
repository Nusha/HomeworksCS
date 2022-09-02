// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreatMatrixIntRandom(int row, int col)
{
    if (row < 2)
    {
        Console.WriteLine("Массив не является двумерным");
        return null!;
    }
    else
    {
        // int col = row;
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

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Число столбцов матрицы A не равно числу строк матрицы B, нельзя перемножить"); return null!;
    }
    else
    {
        int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixB.GetLength(0); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
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


Console.Clear();

Console.Write ("Введите количество cтрок в массиве А 'mA': ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество столбцов в массиве А 'nA': ");
int n = Int32.Parse(Console.ReadLine()!);
int[,] matrixA = CreatMatrixIntRandom(m,n);

Console.Write ("Введите количество строк в массиве B 'rB': ");
int r = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество столбцов в массиве B 'cB': ");
int c = Int32.Parse(Console.ReadLine()!);
int[,] matrixB = CreatMatrixIntRandom(r,c);

int[,] matrixC = MultiplyMatrix(matrixA,matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
PrintMatrix(matrixC);


