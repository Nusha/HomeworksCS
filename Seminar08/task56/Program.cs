// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreatMatrixIntRandom(int row)
{
    if (row < 2)
    {
        Console.WriteLine("Массив не является двумерным");
        return null!;
    }
    else
    {
        int col = row;
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

int[] FindMinSumValue(int[,] matrix)
{
    if (matrix != null)
    {
        {
            int size = matrix.GetLength(0);
            int[] array = new int[size];
            int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

                array[k] = sum;
                k++;
            }
            return array;
        }
    }
    else Console.WriteLine("Не передано значение двумерного масcива"); return null!;
}

int? FindMinLine(int[] array)
{
    if (array != null)
    {
    int min = array[0];
    int minIndex = 0;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];

            minIndex = i;
        }
    }
return minIndex+1;
    }
     else Console.WriteLine("Не передано значение маcсива"); return null!;
}

// void PrintArray(int[] arr)
// {
//     if (arr != null)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write(i < arr.Length - 1 ? $"{arr[i],5}|" : $"{arr[i],5}");
//         }
//         Console.Write("]");
//     }
//     else
//     {
//         Console.WriteLine("Не переданы значения масcива для вывода на экран");
//     }
// }


Console.Clear();

Console.Write ("Введите количество рядов и колонок в массиве (прямоугольный массив ряды = колонки): ");
int m = Int32.Parse(Console.ReadLine()!);
int [,] matrix = CreatMatrixIntRandom(m);
PrintMatrix(matrix);
int[] array = FindMinSumValue(matrix);
int? minline = FindMinLine(array);
// PrintArray(array); //Для отладки и проверки
Console.WriteLine();
if (minline != null) Console.WriteLine($"{minline} строка");
Console.WriteLine();












