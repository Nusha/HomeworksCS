// /Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

double[] FindAverageInCol(int[,] matrix)
{
    if (matrix != null)
    {
        int size = matrix.GetLength(1);
        double[] array = new double[size];
        int k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double avg = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                avg += matrix[i, j];
            }
            avg = Math.Round(avg / matrix.GetLength(0), 1);
            array[k] = avg;
            k++;
        }


        return array;
    }

    else Console.WriteLine("Не передано значение двумерного масива"); return null!;
}

void PrintArray(double[] arr)
{
    if (arr != null)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(i < arr.Length - 1 ? $"{arr[i],5}|" : $"{arr[i],5}");
        }
        Console.Write("]");
    }
    else
    {
        Console.WriteLine("Не переданы значения масcива для вывода на экран");
    }
}

Console.Clear();

Console.Write ("Введите количество рядов в массиве 'M': ");
int m = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите количество колонок в массиве 'N': ");
int n = Int32.Parse(Console.ReadLine()!);

int [,] matrix = CreatMatrixIntRandom(m,n);

PrintMatrix(matrix);

double [] array = FindAverageInCol(matrix);

PrintArray(array);
Console.Write(" <- Среднее арифметическое каждого столбца");
Console.WriteLine();
Console.WriteLine();






