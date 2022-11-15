// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

void ReplacingRowsWithColumns(int[,] array)
{
    if (array.GetLength(0) > 0 && array.GetLength(1) > 0)
    {
        int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = array[j, i];
            }
        }
        Console.WriteLine($"Размер двумерного массива [{arr.GetLength(0)},{arr.GetLength(1)}]");
        PrintArray(arr);
    }
    else
    {
        Console.Write("Замену выполнить не возможно!");
    }
}

Console.Clear();
int[,] array = GetArray(0, 5);
Console.WriteLine($"Размер двумерного массива [{array.GetLength(0)},{array.GetLength(1)}]");
PrintArray(array);
Console.WriteLine();
ReplacingRowsWithColumns(array);