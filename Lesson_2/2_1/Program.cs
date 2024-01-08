// 1. Напишите программу, которая принемает на вход 
//трёхзначное число и удаляет вторую цифру этого числа. a = 256  => 26

//Console.WriteLine("Enter a number: ");
//int s = int.Parse(Console.ReadLine()!);
//int Last = s % 10;
//int First1 = s / 100;
//int First = First1 * 10;
//int sum = First + Last;
//Console.WriteLine(sum);

//int a = int.Parse(Console.ReadLine()!);
//Console.WriteLine(a / 100 * 10 + a % 10);

//123 % 10 -> 3
//123 % 100 -> 23
//123 % 1000 -> 123

//123 / 10 -> 12
//123 / 100 -> 1
//123 / 1000 -> 0

//Console.WriteLine(a / 1000);

//int a = int.Parse(Console.ReadLine()!);
//Console.WriteLine(a / 100 * 10 + a % 10);

// 2. Напищите прогрмамму, которая принимает вход трёхзначное число
//    и возводит вторую цифру этого числа в степень, равную третьей цифре.

//Console.WriteLine("Введите трехзначное число");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num >= 100 && num < 1000)
//{
//    int num1 = num % 100 / 10;
//    int num2 = num % 10;
//    double result = Math.Pow(num1, num2);
//    Console.WriteLine(result);
//}
//else
//{
//    if (num < 100 || num > 1000)
//    {
//        Console.WriteLine("Вы ввели не трехзначное число");
//    }
//}

//Console.WriteLine("Введите трехзначное число:");
//int s = int.Parse(Console.ReadLine()!);
//Console.WriteLine(Math.Pow(s % 100 / 10, s % 10));

Console.WriteLine("Введите трехзначное число:");
int s = int.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Pow(s / 10 % 10, s % 10));