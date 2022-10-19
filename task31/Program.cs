// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int ImputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write(arr[i] + "]");
            break;
        }
        Console.Write(arr[i] + ", ");
    }
}

int SumPositiv(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sum += array[i];
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item < 0) sum += item;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = ImputNumber();
int[] array = FillArray(sizeArray, -9, 9);
Console.Write("В массиве ");
PrintArray(array);
Console.Write($" сумма положительных чисел равна {SumPositiv(array)}, сумма отрицательных равна {SumNegative(array)}");
