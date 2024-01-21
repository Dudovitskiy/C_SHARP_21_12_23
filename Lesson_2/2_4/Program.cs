// 4. Напишите программу, которая выводит третью цифру заданного числа
//    или сообщает, что третье цифры нет.

Console.WriteLine("Enter a numbers:");
int a = int.Parse(Console.ReadLine()!);
if (a>= 100)
{
   int result = a % 1000 / 100;
    Console.WriteLine(result);
}
else
{
   if (a < 100)
    {
       Console.WriteLine("Eror");
    }
}
//int result = a / 100 % 10;