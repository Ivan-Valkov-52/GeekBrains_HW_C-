// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

void SumDiagonalElementsArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
                Console.Write(array[i, j]);
                if (i == array.GetLength(0) - 1 || j == array.GetLength(1) - 1)
                {
                    Console.Write(" = ");
                }
                else
                {
                    Console.Write(" + ");
                }
            }
        }
    }
    Console.Write(sum);
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов двумерного массива: ");
int column = InputNumber();
int[,] array = GetArray(line, column, 1, 9);
PrintArray(array);
Console.WriteLine();
SumDiagonalElementsArray(array);