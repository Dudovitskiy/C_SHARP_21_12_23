/ 3. Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
Console.Clear();

string str = "Hello";
int CharToArr(string word)
{
string vowels = "aeiou";
int value = 0;

for (int i = 0; i < word.Length; i++)
{
if (vowels.Contains(word[i]))
value++;

}
return value;
}
Console.WriteLine(CharToArr(str));
Мария Андреева https://acmp.ru/index.asp?main=tasks
Мария Андреева https://leetcode.com/
Мария Андреева Рекурсия
https://www.youtube.com/watch?v=F4HNO4rCQ2c&ab_channel=KhanAcademyRussian
https://youtu.be/rh1mP02NFoM?t=229
https://skillbox.ru/media/code/rekursiya-vokrug-nas/