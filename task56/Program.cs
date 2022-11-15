// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректные данные: ");
    return num;
}

int SumArrayElements(int[] arr)
{
    int sum = 0;
    foreach (int el in arr)
    {
        sum += el;
    }
    return sum;
}

int IndexMinElementsArray(int[] arr)
{
    int min = arr[0];
    foreach (int el in arr)
    {
        if (el < min) min = el;
    }
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == min)
        {
            index = i;
        }
    }
    return index;
}

void LineSmallSumElementsArray(int[,] array)
{
    int[] arrayColumn = new int[array.GetLength(0)];
    int[] arrayLine = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayLine[j] = array[i, j];
        }
        arrayColumn[i] = SumArrayElements(arrayLine);
    }
    Console.WriteLine("Номер строки с наименьшей суммой элементов двумерного массива: " + (IndexMinElementsArray(arrayColumn) + 1));
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов двумерного массива: ");
int column = InputNumber();
int[,] array = GetArray(line, column);
PrintArray(array);
Console.WriteLine();
LineSmallSumElementsArray(array);