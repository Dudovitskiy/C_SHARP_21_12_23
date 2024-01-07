// 2. Напишите программу, которая на вход принемает целое число N,
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
int count = -b1;
while (count <= b1)
{
    Console.Write(count+ " ");
    count++;
}