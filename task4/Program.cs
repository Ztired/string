// Задача 4*(не обязательная): 
// Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

string GetReversString(string str)
{
    string reversstring = "";
    int beginword = 0;
    int endword = str.Length - 1;

    for (int i = str.Length - 1; i >= 0; i--)
    {
// переворот строки до первого слова
        if (str[i] == ' ')
        {
            beginword = i + 1;
            for (int j = beginword; j <= endword; j++)
            {
                reversstring += str[j];
            }
            endword = beginword - 2;
            reversstring += " ";
        }
 // переворот первого слова
        if (i == 0 && str[0] != ' ')
        {
            beginword = i;
            for (int j = 0; j <= endword; j++)
            {
                reversstring += str[j];
            } 
        }
    }
    return reversstring;
}


Console.Write("Введите строку: ");
Console.WriteLine();
string inputString = Console.ReadLine();
string inputReversString = GetReversString(inputString);
Console.Write($"{inputReversString}");
Console.WriteLine();
