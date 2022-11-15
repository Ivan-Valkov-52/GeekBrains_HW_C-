// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array)
{
    int index = 1;
    int coordinateX = 0;
    int coordinateY = -1;
    int moveRow = 0;
    int moveColumn = 1;
    while (index <= array.Length)
    {
        if (0 <= (coordinateX + moveRow) && (coordinateX + moveRow) < array.GetLength(0) && 0 <= (coordinateY + moveColumn) && (coordinateY + moveColumn) < array.GetLength(1) && array[coordinateX + moveRow, coordinateY + moveColumn] == 0)
        {
            coordinateX += moveRow;
            coordinateY += moveColumn;
            array[coordinateX, coordinateY] = index;
            index++;
        }
        else
        {
            if (moveColumn == 1)
            {
                moveColumn = 0;
                moveRow = 1;
            }
            else if (moveRow == 1)
            {
                moveRow = 0;
                moveColumn = -1;
            }
            else if (moveColumn == -1)
            {
                moveRow = -1;
                moveColumn = 0;
            }
            else if (moveColumn == 0)
            {
                moveRow = 0;
                moveColumn = 1;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]}" + " ");
                continue;
            }
            Console.Write(array[i, j] + " ");
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


Console.Clear();
Console.Write("Введите количество столбцов и строк прямоугольного, двухмерного массива: ");
int columnAndLine = InputNumber();
int[,] array = new int[columnAndLine, columnAndLine];
FillSpiralArray(array);
PrintArray(array);