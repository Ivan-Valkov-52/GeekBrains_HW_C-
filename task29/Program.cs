int ImputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Ввели не корректное значение! Попробуйте ещё раз: ");
    return num;
}

int LenghtArray(int val)
{
    int count = 0;
    int index = 0;
    while (index < val)
    {
        val /= 10;
        count++;
    }
    return count;
}

int[] ArrayNumbers(int num)
{
    int[] array = new int[LenghtArray(num)];
    for (int index = 0; index < array.Length; index++)
    {
        array[array.Length - index - 1] = (int)(num / Math.Pow(10, index)) % 10;
    }
    return array;
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите любое число: ");
int number = ImputNumber();
int[] array = ArrayNumbers(Math.Abs(number));
Console.Write($"Сумма цифр числа {number} -> {SumNumbers(array)}");
