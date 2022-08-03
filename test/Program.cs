Console.Clear();
string[] arr = new string[] {"hello", "2", "world", ":-)"};



int CountLenght(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillArray(int num, string[] array)
{
    string[] newArray = new string[num];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    if (arr.Length == 0) Console.Write($"[]");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"]");
    }
}


int number = CountLenght(arr);
string[] newArr = FillArray(number, arr);
PrintArray(arr);
Console.Write($" -> ");
PrintArray(newArr);
