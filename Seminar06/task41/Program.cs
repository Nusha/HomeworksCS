// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] CreatArrFromKeyboard()
{
    Console.Write("Введите размер массива: ");
    int size = Int32.Parse(Console.ReadLine()!);
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
    else Console.WriteLine("Массив должен состоять как минимум из 2 элементов."); return null!;
}

int[] CreatArrFromKeyboardInString()
{
    Console.Write("Введите числа через пробел (также можно использовать '.' , ',' , ';' , '/' в качестве разделителей значений) в одну строку: ");
    //int size = 0;
    char[] sep = new char[] { ' ', ',', ';', '/', '.' };
    int[] array = Console.ReadLine()!.Split(sep, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();
    int size = array.Count();
    if (size > 1)
    {
        int[] arr = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            arr[i] = array[i];
        }
        return arr;
    }
else Console.WriteLine("Массив должен состоять как минимум из 2 элементов."); return null!;
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

Console.Write("Хотите ввести все значения массива в одну строку? Введите 'y' (Да) или любое другое значение (Нет): ");
string input = Convert.ToString(Console.ReadLine()!);

int[] array = input == "y"?CreatArrFromKeyboardInString():CreatArrFromKeyboard();  

PrintArray8(array);

int? res = CountAboveZero(array);

if (res.HasValue) 
{
    Console.WriteLine($" -> {CountAboveZero(array)}");
}
else Console.WriteLine("Ошибка - нет значения");
