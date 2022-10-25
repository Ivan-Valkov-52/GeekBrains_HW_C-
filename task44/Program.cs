// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputNomber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

int[] FibonacciNomber(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    for (int i = 1; i < number; i++)
    {
        if (i == 1)
        {
            array[i] = 1;
        }
        else
        {
            array[i] = array[i - 1] + array[i - 2];
        }
    }
    // if (number <= 2)
    // {
    //     array[0] = 0;
    //     if (number == 2)
    //     {
    //         array[1] = 1;
    //     }
    // }
    // else
    // {
    //     array[0] = 0;
    //     array[1] = 1;
    //     for (int i = 2; i < array.Length; i++)
    //     {
    //         array[i] = array[i - 1] + array[i - 2];
    //     }
    // }
    return array;
}

Console.Clear();
Console.Write("Введите целое число: ");
int number = InputNomber();
Console.Write($"{number} -> ");
Console.Write(string.Join(" ", FibonacciNomber(number)));