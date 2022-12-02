string[] FillArray(int amountElements)
{
    string[] array = new string[amountElements];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter element {i + 1} of {amountElements}:");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] GetArrayWithElementsOfSomeLength(string[] array, int elementLength)
{
    string[] arrayNew = {};
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elementLength)
        {
            size++;
            Array.Resize(ref arrayNew, size);
            arrayNew[size - 1] = array[i];
        }
    }
    return arrayNew;
}

void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($" '{item}' ");
    }
}

string[] array = FillArray(4);
PrintArray(array);
Console.WriteLine();
string[] arrayResulting = GetArrayWithElementsOfSomeLength(array, 3);
PrintArray(arrayResulting);