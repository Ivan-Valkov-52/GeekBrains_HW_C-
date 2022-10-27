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

void ArithmeticMeanArray(int[,] array)
{
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        result = result / array.GetLength(0);
        if (j == array.GetLength(1) - 1)
        {
            Console.Write(Math.Round(result, 1));
            break;
        }
        Console.Write(Math.Round(result, 2) + "; ");
    }
}

Console.Clear();
int[,] array = GetArray(1, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMeanArray(array);