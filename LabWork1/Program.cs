int[] array = { 7, 0, -4, 3, 1, -2, 5 };

OutputArray(array);
Console.WriteLine();
SelectionSort(array);
Console.WriteLine();
BubbleSort(array);
Console.WriteLine();
InsertionSort(array);

void OutputArray(int[] array)
{
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

void SelectionSort(int[] array)
{
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        int n_min = i;
        for (global::System.Int32 j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[n_min])
            {
                n_min = j;
            }
        }
        if (n_min != i)
        {
            int b = array[i];
            array[i] = array[n_min];
            array[n_min] = b;
        }
        Console.Write($"{array[i]}\t");
    }
}

void BubbleSort(int[] array)
{
    for (global::System.Int32 i = 0; i < array.Length; i++)
    {
        for (global::System.Int32 j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j+1])
            {
                int b = array[j];
                array[j] = array[j+1];
                array[j+1] = b;
            }
        }
        Console.Write($"{array[i]}\t");
    }
}

void InsertionSort(int[] array)
{
    for (global::System.Int32 i = 1; i < array.Length; i++)
    {
        int x = array[i];
        int j = i - 1;
        if (x < array[j] && j >= 1)
        {
            array[j+1] = array[j];
            j = j - 1;
        }
        else
        {
            array[j + 1] = x;
        }
        Console.Write($"{array[i]}\t");
    }
}

