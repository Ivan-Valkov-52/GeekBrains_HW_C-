// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

void SearchElement(int el, int[] arr)
{
    bool text = false;
    int count = 0;
    foreach (int val in arr)
    {
        if (val == el)
        {
            text = true;
            count++;
        }
    }
    if (text)
    {
        Console.Write($" -> Да. Число повторяется {count} раз");
    }
    else
    {
        Console.Write(" -> Нет");
    }
}

Console.Clear();
int[] array = GetArray(9, -5, 5);
PrintArray(array);
SearchElement(3, array);