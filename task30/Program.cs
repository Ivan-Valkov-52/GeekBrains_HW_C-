int ImputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Ввели не корректное значение! Попробуйте ещё раз: ");
    return num;
}

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] mas)
{
    if (mas.Length != 0)
    {
        Console.Write("[");
        for (int i = 0; i < mas.Length; i++)
        {
            if (i == mas.Length - 1)
            {
                Console.Write(mas[i] + "]");
                break;
            }
            Console.Write(mas[i] + ", ");
        }
    }
    else
    {
        Console.Write($"Не бывает массива {mas.Length} длины!");
    }

}

Console.Clear();
Console.Write("Введите размер массива: ");
int sizeArray = ImputNumber();
int[] array = RandomArray(sizeArray);
Console.Write($"Рандомно заполненный массив длиной {sizeArray} -> ");
PrintArray(array);

