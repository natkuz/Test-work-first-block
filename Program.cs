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
