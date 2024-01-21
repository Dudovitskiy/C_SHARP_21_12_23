Задача 4.

// Дано натуральное число
// в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.

class Program{
static void Main(){
Console.WriteLine("enter number: ");
Print(" ");

int numb = int.Parse(Console.ReadLine());
int length = numb.ToString().Length;
Print(" ");

if(numb > 0 && numb < 100000){
Print("Number : " + numb);

int[] array = CreationArray(numb, length);
Array.Sort(array);
Array.Reverse(array);
foreach(int num in array){
Print("element : " + num);
}
}
else{
Print("ERROR! Number < 0 or > 100.000");
}
}
static void Print(string res) { //функция выводящая результат на экран
Console.WriteLine(res);
}
static int[] CreationArray(int numb, int length){
int[] array = new int[length];
for(int i = 0; i < length; i++){
array[i] = numb % 10;
numb /=10;
}

return array;
}

}