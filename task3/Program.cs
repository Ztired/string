// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

string GetReversString(string str)
{
    string reversstring = "";
    for (int i = 0; i < str.Length; i++)
    {
        reversstring += str[str.Length - 1 -i];
    }
    return reversstring;
}

bool CheckStringPallindrom(string str1, string str2)
{
    if (String.Compare(str1, str2) == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void OutputResult(bool palindrom, string str3)
{
    if (palindrom == true)
    {
        Console.WriteLine($"Введенная строка '{str3}' является палиндромом");
    }
    else
    {
        Console.WriteLine($"Введенная строка '{str3}' НЕ является палиндромом");
    }
}

Console.Write("Введите строку: ");
string inputString = Console.ReadLine();
string inputReversString = GetReversString(inputString);
OutputResult (CheckStringPallindrom(inputString, inputReversString), inputString);

