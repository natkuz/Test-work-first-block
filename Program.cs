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