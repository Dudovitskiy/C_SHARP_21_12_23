// 4. Напишите программу, которая на вход принемает натуральное число N,
//    а на выходе показывает его цифры через запятую.  + "\n"


Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine()!);
string a = "";
if (n > 0)
{
    while (n > 0)
    {
        a = n % 10 + "," + a;
        n = n / 10;     
    }
 Console.Write(a.Trim(',') + "\n");
}
else
    Console.Write("Некоректное число");