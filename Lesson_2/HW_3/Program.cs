// 3. Наришите программу, которая принимает на вход целое число из отрезка[10,99],
//    и показывает наибольшую цифру числа.

Console.WriteLine("Введите число из отрезка[10,99]");
int x = int.Parse(Console.ReadLine()!);

if (x < 9 || x > 100)
{
    Console.WriteLine("Неправильное введено число");
}
    else
    {
        int a = x / 10;
        int b = x % 10;
        Console.WriteLine(Math.Max(a, b));
    }