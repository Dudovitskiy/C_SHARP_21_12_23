﻿Console.WriteLine("Enter a numbers:");

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}
Console.WriteLine("Точка находится на оси кординат");