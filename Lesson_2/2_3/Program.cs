// 3. Напишите программу, которая будет принемать на вход два числа и выводить,
//    является ли второе число кратным первому. Если второе число некратно первому,
//    то программа выводит остаток деления 

Console.WriteLine("Enter a numbers:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

if (a % b == 0)
{
    Console.WriteLine("CRATNO")
}
else
{
     Console.WriteLine("NECRATNO")
}