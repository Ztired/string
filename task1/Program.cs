
// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


string GetStringFromArrayChar(char[,] array)
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str += array[i, j];    
        }
    }
    return str;
}

char[,] chars = {
    {'H', 'e', 'l', 'l', 'o'},
    {'W', 'o', 'r', 'l', 'd'}
};
Console.WriteLine($"Итоговая строка {GetStringFromArrayChar(chars)} ");