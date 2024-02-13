//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
            return;

        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(arr, arr.Length - 1);
    }
}
