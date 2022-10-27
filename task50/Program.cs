int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

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

void ElementsArray(int numberLine, int numberColumn, int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == numberLine - 1 && j == numberColumn - 1)
            {
                Console.Write($"[{numberLine},{numberColumn}] -> {array[i, j]}");
                return;
            }
        }
    }
    Console.Write($"[{numberLine},{numberColumn}] -> такого числа в массиве нет!");
}

Console.Clear();
Console.Write("Введите номер строки двумерного массива: ");
int numberLine = InputNumber();
Console.Write("Введите номер столбца двумерного массива: ");
int numberColumn = InputNumber();
int[,] array = GetArray(1, 9);
PrintArray(array);
ElementsArray(numberLine, numberColumn, array);