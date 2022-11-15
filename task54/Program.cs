// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
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

void NewArray(int[,] array)
{
    int[] arr = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[j] = array[i, j];
        }
        SortArray(arr);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arr[j];
        }
    }
}

void SortArray(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j + 1] > arr[j])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректные данные: ");
    return num;
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов двумерного массива: ");
int column = InputNumber();
Console.WriteLine();
int[,] array = GetArray(line, column);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированный по строчно двумерный массив: ");
NewArray(array);
PrintArray(array);
