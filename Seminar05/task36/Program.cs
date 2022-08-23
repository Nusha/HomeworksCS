// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0





int[] CreateArrayAskElements(int size)
{
    if (size >= 4 && size <= 20)
    {



        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(-99, 99);
        }
        return array;

    }
    else
    {
        Console.WriteLine("Размер массива вне допустимого диапазона");
        return null!;
    }
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
    else
    {
        Console.WriteLine("Не переданы значения масcива для вывода на экран");
    }
}

object SummOddIndex(int [] arr)
{
    if (arr != null)
    {
 int summ = 0;
 for (int i = 1; i < arr.Length; i=i+2)
 {
    summ = summ + arr[i];
 }  
return summ;
     }
else
    {
        
        Console.WriteLine("Значение массива не передано в метод");
        return null!;
        
       
    }

}

Console.Clear();
Console.Write("Введите размер массива в диапазоне от 4 до 20: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArrayAskElements(size);
PrintArray8(array);
SummOddIndex(array);
if (array != null) Console.WriteLine($"  -> {SummOddIndex(array)}");
