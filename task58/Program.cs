// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] MatrixMultiplication(int[,] arrayFirst, int[,] arraySecond)   Первый вариант, если матрицы одинаковые
// {
//     int sum = 0;
//     int[,] resultArray = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
//     for (int i = 0; i < resultArray.GetLength(0); i++)
//     {

//         for (int k = 0; k < resultArray.GetLength(1); k++)
//         {
//             sum = 0;
//             for (int j = 0; j < resultArray.GetLength(1); j++)
//             {
//                 sum = sum + (arrayFirst[i, j] * arraySecond[j, k]);
//             }
//             resultArray[i,k] = sum;
//         }
//     }
//     return resultArray;
// }

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

int[,] MatrixMultiplication(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int k = 0; k < resultArray.GetLength(1); k++)
        {
            for (int j = 0; j < arrayFirst.GetLength(1); j++)
            {
                resultArray[i, k] += arrayFirst[i, j] * arraySecond[j, k];
            }
        }
    }
    return resultArray;
}

Console.Clear();
Console.Write("Введите количество строк двумерного массива №1: ");
int line1 = InputNumber();
Console.Write("Введите количество столбцов двумерного массива №1: ");
int column1 = InputNumber();
Console.Write("Введите количество строк двумерного массива №2: ");
int line2 = InputNumber();
Console.Write("Введите количество столбцов двумерного массива №2: ");
int column2 = InputNumber();
Console.WriteLine("Первая матрица: ");
int[,] arrayFirst = GetArray(line1, column1);
PrintArray(arrayFirst);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
int[,] arraySecond = GetArray(line2, column2);
PrintArray(arraySecond);
Console.WriteLine();
Console.WriteLine("Результат произведения двух матриц: ");
if (arrayFirst.GetLength(1) == arraySecond.GetLength(0))
{
    int[,] newArray = MatrixMultiplication(arrayFirst, arraySecond);
    PrintArray(newArray);
}
else
{
    Console.WriteLine($"Матрицу №1 умножить на матрицу №2 нельзя, т.к. число столбцов матрицы №1: {arrayFirst.GetLength(1)} не равно числу строк матрицы №2: {arraySecond.GetLength(0)}");
}

