// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] CreateArrayAskElements(int size)
{
    if (size >= 4 && size <= 20)
    {



        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 999);
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

object FindEven(int [] arr)
{
    if (arr != null)
    {
       
    int count=0;

 foreach (int item in arr)
 {
    if (item%2 ==0) count = count+1;

 }
// Console.WriteLine(count);
return count;
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
FindEven(array);
if (array != null) Console.WriteLine($"  -> {FindEven(array)}" );
