﻿// 3. Напишите программу, которая принемает на вход кординаты точки (x,y),
//    причём X != 0 и y != 0 и выдает номер кординатной четверти плоскости,
//    в которой находится эта точка.

Console.WriteLine("Введите кординату x");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кординату y");
int y = int.Parse(Console.ReadLine()!);

if (x != 0 || y != 0)
{
    Console.WriteLine("Ошибка кординат");
}    
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится на оси кординат 1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится на оси кординат 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится на оси кординат 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится на оси кординат 4");
}
