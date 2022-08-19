// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] CreateArray8elements(int min, int max)
{
    if (min < max)
    {
        //  return; //Console.WriteLine("Минимальное значение не может быть больше максимального"));



        int[] array = new int[8];

        for (int i = 0; i <= 7; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        return array;

    }
    else
    {
        Console.WriteLine("Минимальное значение не может быть больше максимального.");
        return null!;
}
}

void PrintArray8(int[] array)
{
    if (array != null)
    {
    Console.Write("[");
    for (int i = 0; i <= 7; i++)
    {
        Console.Write($" {array[i]},");
    }
    Console.WriteLine("]");
    }
    else
    {
        Console.WriteLine("Не переданы значения масcива для вывода на экран.");
    }
}
Console.Clear();
Console.Write("Введите минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray8elements(min, max);
PrintArray8(array);
