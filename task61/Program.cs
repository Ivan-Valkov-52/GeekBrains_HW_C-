// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника


int[,] GetArray(int lenght)
{
    int[,] array = new int[lenght, lenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, 0] = 1;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int x = 30, y = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.SetCursorPosition(x - i - 1, y + i);
        for (int j = 0; j <= i; j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write(array[i, j] + " ");
            }
        }
    }
}

Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int number = int.Parse(Console.ReadLine());
int[,] array = GetArray(number);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите любую клавишу,чтобы выйти из программы....");
Console.ReadKey();