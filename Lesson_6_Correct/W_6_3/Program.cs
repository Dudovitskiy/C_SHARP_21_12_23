void Func(string word, int index)
{
if (index == word.Length - 1)
return;
else
{
string vowels = "aeyoiu";

if(vowels.Contains(word[index]))
{Func(word, index + 1);}
else{
Console.Write($"{word[index]} ");
Func(word, index + 1);}}


}

Func("Hell to World", 0);