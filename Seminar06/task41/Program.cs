// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите размер массива: ");
var m = Int32.Parse(Console.ReadLine()!);

int[] CreatArrFromKeyboard(int size)
{
    if (size > 1)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите значение для {i} индекса массива: ");
            array[i] = Int32.Parse(Console.ReadLine()!);
        }
        return array;
    }
    else return null!;
}

void PrintArray8(int[] arr)
{
    if (arr != null)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($" {arr[i]},");
        }
        Console.Write("]");
    }
}

int? CountAboveZero(int[] arr)
{
    if (arr != null)
    {
        int num = 0;
        int? result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result = arr[i] > 0 ? num = num + 1 : num;
        }
        return result;
    }
    else Console.WriteLine($"Передано недопустимое значение в метод."); return null;
}

int[] array = CreatArrFromKeyboard(m);

PrintArray8(array);

int? res = CountAboveZero(array);

if (res.HasValue) 
{
    Console.WriteLine($" -> {CountAboveZero(array)}");
}
else Console.WriteLine("Ошибка - нет значения");

