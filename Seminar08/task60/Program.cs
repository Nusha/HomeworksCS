// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreatMatrix3DIntRandom(int x, int y, int z, int[] arr)
{
    if (x < 2)
    {
        Console.WriteLine("Массив не является многомерным");
        return null!;
    }
    else if (x * y * z > 90)
    {
        Console.WriteLine("Превышен максимально допустимый размер массива (не хватает неповторяющихся двузначных чисел)");
        return null!;
    }
    else
    {

        int[,,] matrix3D = new int[x, y, z];
        Random rnd = new Random();
        int[] col = arr;
        int count = 0;
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)
                for (int k = 0; k < matrix3D.GetLength(2); k++)
                {
                    matrix3D[i, j, k] = col[count];  //rnd.Next(10,99);
                    count++;
                }

        }
        return matrix3D;
    }
}

void PrintMatrix3D(int[,,] matrix3D)
{
    if (matrix3D != null)
    {
        Console.WriteLine();
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            // Console.Write("[");

            for (int j = 0; j < matrix3D.GetLength(1); j++)

            {
                for (int k = 0; k < matrix3D.GetLength(2); k++)
                {
                    if (j < matrix3D.GetLength(1) - 1) Console.Write($"{matrix3D[i, j, k],5}({i},{j},{k})");
                    else Console.Write($"{matrix3D[i, j, k],5}({i},{j},{k})");

                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Не передано значение массива");
    }
}

int[] MakeArrayTwoDigitInOrder()
{
    int[] array = new int[90];
    for (int i = 0; i < 90; i++)
    {
        array[i] = i + 10;
    }

    return array;
}

int[] ShuffleArray(int[] arr)
{

    Random rnd = new Random();

    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rnd.Next(i + 1);

        int tmp = arr[j];
        arr[j] = arr[i];
        arr[i] = tmp;
    }
    return arr;
}

// Для проверки и отладки
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
//         Console.WriteLine();
//     }
//     else
//     {
//         Console.WriteLine("Не переданы значения масcива для вывода на экран");
//     }
// }



Console.Clear();

Console.Write ("Введите размер массива Х: ");
int x = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите размер массива Y: ");
int y = Int32.Parse(Console.ReadLine()!);
Console.Write ("Введите размер массива Z: ");
int z = Int32.Parse(Console.ReadLine()!);


int[] array = MakeArrayTwoDigitInOrder();

Console.WriteLine();
int [] arr = ShuffleArray(array);

int[,,] matrix3d = CreatMatrix3DIntRandom(x,y,z, arr);
PrintMatrix3D(matrix3d);

