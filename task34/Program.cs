// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123. 
// [5, 18, 123, 6, 2] -> 1 
// [1, 2, 3, 6, 2] -> 0 
// [10, 11, 12, 13, 14] -> 5

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

int SearchElement(int min, int max, int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el >= min && el <= max)
        {
            // Console.Write(" " + el);
            count++;
        }
    }
    return count;
}

Console.Clear();
int[] array = GetArray(123, 1, 123);
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.Write("]");
Console.Write(" -> " + SearchElement(10, 99, array));
