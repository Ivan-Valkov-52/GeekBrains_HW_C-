// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. Например, изначально массив выглядел вот так: 
// 1 4 7 2         1 4 7 2 
// 5 9 2 3   ->    5 81 2 9
// 8 4 2 4         8 4 2 4

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

int[,] GetArray(int line, int column, int minValue, int maxValue)
{
    int[,] arr = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов двумерного массива: ");
int column = InputNumber();
int[,] array = GetArray(line, column, 1, 9);
PrintArray(array);
NewArray(array);
Console.WriteLine();
PrintArray(array);