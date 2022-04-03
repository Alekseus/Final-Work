// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.

Console.Clear();
string[] GetNewArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int size = 0;
    for (var i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[size] = firstArray[i];
            size++;
        }
    }
    Array.Resize(ref newArray, size);
    return newArray;
}
void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

string[] firstArray = { "Moscow", "5", "Sun", "Kirov", "2", "899",  "IT" };
string[] newArray = GetNewArray(firstArray);
Console.WriteLine("Изначальный массив:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Итоговый массив:");
PrintArray(newArray);
