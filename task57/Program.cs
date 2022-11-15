// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

using System.Collections.Generic;

int[,] GetArray(int minValue, int maxValue)
{
    int line = new Random().Next(minValue, maxValue + 1);
    int column = new Random().Next(minValue, maxValue + 1);
    int[,] arr = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == array.GetLength(1) - 1)
            {
                Console.Write(array[i, j]);
                break;
            }
            Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine();
    }
}

void FrequencyDictionary1(int[,] array)
{
    int max = 0;
    foreach (int item in array)
    {
        if (item > max)
        {
            max = item;
        }
    }
    
    int count;
    for (int i = 1; i <= max; i++)
    {
        count = 0;
        foreach (int item in array)
        {
            if (i == item)
            {
                count++;
            }
        }
        if (count > 0)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine($"{i} встречается {count} раза");
            }
            else
            {
                Console.WriteLine($"{i} встречается {count} раз");
            }
        }
    }
}

void FrequencyDictionary2(int[,] array)
{
    // Ассоциативный массив
    Dictionary<int, int> myMap = new Dictionary<int, int>();
    int count;
    for (int i = 1; i < 10; i++)
    {
        count = 0;
        foreach (int item in array)
        {
            if (i == item)
            {
                count++;
            }
        }
        if (count > 0)
        {
            myMap.Add(i, count);
        }
    }
    foreach (var item in myMap)
    {
        Console.WriteLine("Число {0} встречается {1} раз", item.Key, item.Value);
    }
}

Console.Clear();
int[,] array = GetArray(1, 5);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary1(array);

