// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

using static System.Console;
Clear();

int digitCount(int digit)//подсчет кол-ва цифр
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}

WriteLine("введите трёхзначное число");
int digit = int.Parse(ReadLine());
//WriteLine("What is the digit of this number?");//если есть желание чтоб было только 3 цифру числа, - то просто удлать нуджно эту строку 
int number = 3; // если 22 строчку удаляете, - то просто вместо ридлайна надо написать номер числа, которое нужно вывести


if (digitCount(digit) <= -number || digitCount(digit) >= number)
{
    for (int i = 0; i < digitCount(digit); i++)
    {
        digit = (int)(digit / Math.Pow(10, (digitCount(digit) - number)));
        digit %= 10;
    }
    WriteLine($"{number} цифра  {digit}");
}
else WriteLine($"{number} цифра отсутствует {digit}");