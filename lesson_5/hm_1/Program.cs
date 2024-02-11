// 1. Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

void InfEnter()
{
string word;

while (true)
{
Console.Write("Output any number: ");
word = Console.ReadLine()!;

if (word != "q")
{
int count = 0;
int number = int.Parse(word);
for (; number > 0; number /= 10)
count += number % 10;

if (count % 2 == 0)
{
Console.WriteLine("Game is over! Number is even");
return;
}
}
else
return;
}
}

InfEnter();