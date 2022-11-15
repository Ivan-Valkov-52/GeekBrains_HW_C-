// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ReplacingFirstAndLastRows(int[,] array) {
    int tmp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmp;
    }
}

Console.Clear();
int[,] array = GetArray(1, 9);
PrintArray(array);
Console.WriteLine();
ReplacingFirstAndLastRows(array);
PrintArray(array);