// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// // [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2





// double[] CreateArrayAskElements(int size)
// {
//     if (size >= 4 && size <= 20)
//     {



//         double[] array = new double[size];

//         for (int i = 0; i < size; i++)
//         {
//             array[i] =  Math.Round(new Random().NextDouble()*100, 1);
//         }
//         return array;

//     }
//     else
//     {
//         Console.WriteLine("Размер массива вне допустимого диапазона");
//         return null!;
//     }
// }

// void PrintArray8(double[] arr)
// {
//     if (arr != null)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             Console.Write($" {arr[i]},");
//         }
//         Console.Write("]");
//     }
//     else
//     {
//         Console.WriteLine("Не переданы значения масcива для вывода на экран");
//     }
// }

// object FindMinArr(double [] arr)
// {
//     if (arr != null)
//     {
//         double min = arr[0];
//         foreach (var item in arr)
//         {
//          if (item < min) min = item;  
//         }
//     return min;
//     }
// else
//     {
        
//         Console.WriteLine("Значение массива не передано в метод");
//         return null!;
        
       
//     }

// }

// object FindMaxArr(double [] arr)
// {
//     if (arr != null)
//     {
//         double max = arr[0];
//         foreach (var item in arr)
//         {
//          if (item > max) max = item;  
//         }
//     return max;
//     }
// else
//     {
        
//         Console.WriteLine("Значение массива не передано в метод");
//         return null!;
        
       
//     }

// }

// Console.Clear();
// Console.Write("Введите размер массива в диапазоне от 4 до 20: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] array = CreateArrayAskElements(size);
// PrintArray8(array);
// double min = Convert.ToDouble(FindMinArr(array));
// double max = Convert.ToDouble(FindMaxArr(array));
// double dif = max - min;
// if (array != null) Console.WriteLine($" -> {Math.Round(dif, 1)}");

int candis = 10;
int step = 2;

int InputNumber (string text)
{
Console.WriteLine(text);
int userNumberInput = Convert.ToInt32(Console.ReadLine());
if (userNumberInput < 9 && userNumberInput > 0) return userNumberInput;
else 
{
    Console.WriteLine("Не мухлюйте. Вам придется забрать 1 кофету");
    return 1; 
}
}
bool turnFirstGamer = true;
while (candis > 0)
{
    if (turnFirstGamer) 
    {
        candis = candis - InputNumber($"Осталось {candis} конфет. Ходит первый игрок. Сколько конфет забираете? :  ");
        turnFirstGamer = !turnFirstGamer;
    }
    else
     {
        Console.WriteLine($"Осталось {candis} конфет. Ходит второй игрок. Сколько конфет забираете? : ");
        candis = candis - TurnOfIi (candis, step);
        turnFirstGamer = !turnFirstGamer;
    }
}

if (!turnFirstGamer) Console.WriteLine("Выиграл первый игрок");
else Console.WriteLine("Выиграл второй игрок");

int TurnOfIi (int remainsInMethod, int stepInMethod)
{
    int result = 1;

    if (stepInMethod <= remainsInMethod ) result = remainsInMethod;
    else 
    {
        result = remainsInMethod % (stepInMethod + 1);
        
    }
    Console.WriteLine(result);
    return result;
}