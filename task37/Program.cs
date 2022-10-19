int[] GetArray(int size, int minVal, int maxVal)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
            break;
        }
        Console.Write(array[i] + ", ");
    }
}

int InputNomber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Введите корректное значение: ");
    }
    return num;
}

int SumOddElementArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] array = GetArray(InputNomber(), 1, 100);
PrintArray(array);
Console.Write(" -> " + SumOddElementArray(array));