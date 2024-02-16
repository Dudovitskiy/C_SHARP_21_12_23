using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine($"Натуральные числа от 1 до {n}:");
            PrintNaturalNumbers(1, n);
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        }
    }

    static void PrintNaturalNumbers(int current, int N)
    {
        if (current <= N)
        {
            Console.WriteLine(current);
            PrintNaturalNumbers(current + 1, N);
        }
    }
}