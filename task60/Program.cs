// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetRandomArray(int[,,] array)
{
    Random random = new Random();
    bool test;
    int num;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                {
                    num = random.Next(10, 100);
                    test = false;
                    foreach (var el in array)
                    {
                        if (el == num)
                        {
                            test = true;
                            break;
                        }
                        else
                        {
                            index++;
                        }
                        if (index == array.Length)
                        {
                            array[i, j, k] = num;
                        }
                    }
                    index = 0;
                } while (test);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
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
Console.Write("Введите количество листов трехмерного массива: ");
int list = InputNumber();
Console.Write("Введите количество строк трехмерного массива: ");
int line = InputNumber();
Console.Write("Введите количество столбцов трехмерного массива: ");
int column = InputNumber();
int[,,] myArray = new int[list, line, column];
if (myArray.Length < 90)
{
    GetRandomArray(myArray);
    PrintArray(myArray);
}
else
{
    Console.WriteLine("Общая длина массива не может быть больше количества рандомных чисел из промежутка от 10 до 100! Запустите программу заново");
}

