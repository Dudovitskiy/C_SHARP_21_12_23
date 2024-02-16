int sum(int numbers)
{
    if (numbers == 0)
        return 0;
    return sum(numbers / 10) + numbers % 10;
}

Console.WriteLine("Введите число:");
int numbers= int.Parse(Console.ReadLine()!);

Console.WriteLine($"{sum(numbers)}");
 
