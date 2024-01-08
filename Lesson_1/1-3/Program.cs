//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает сумму первой и последней цифры.

Console.WriteLine("Enter a number: ");
int s = int.Parse(Console.ReadLine()!);
int Last = s % 10;
int First = s / 100;
int sum = First + Last;
Console.WriteLine(sum);
