int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

double[,] GetArray(int line, int column, int minValue, int maxValue)
{
    Random rand = new Random();
    double[,] arr = new double[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()), 1);
        }
    }
    return arr;
}

void PrintArray(double[,] inArray)
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

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов двумерного массива: ");
int column = InputNumber();
double[,] array = GetArray(line, column, -5, 5);
PrintArray(array);