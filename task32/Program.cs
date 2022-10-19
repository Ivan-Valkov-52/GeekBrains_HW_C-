// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
    }
    return array;
}

Console.Clear();
int[] array = GetArray(10, -9, 9);
PrintArray(array);
Console.Write(" -> ");
PrintArray(ReplaceArray(array));