// 1. Напишите программу, которая принимает на вхлж число и проверяет,
//    кратно ли оно одновременно 7 и 23


Console.WriteLine("Enter a numbers:");
int a = int.Parse(Console.ReadLine()!);

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}