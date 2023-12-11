using System;

Console.Write("Введите строку: ");
string input = Console.ReadLine();

char[] inputToChars = input.ToCharArray();

Console.Write("Answer One: "+ ReverseString(inputToChars));

string ReverseString(char[] chars)
{
    Array.Reverse(chars);

    return new string (chars);
}

