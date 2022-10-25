// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int InputNomber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

int[] BynarySystem(int number)
{
    int res = 1;
    int count = 0;
    while (res <= number)
    {
        count++;
        res = (int)Math.Pow(2, count);
    }
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (number % 2 == 0)
        {
            array[array.Length - i - 1] = 0;
        }
        else
        {
            array[array.Length - i - 1] = 1;
        }
        number /= 2;
    }
    return array;
}

Console.Clear();
Console.Write("Введите целое число: ");
int number = InputNomber();
Console.Write(number + " -> ");
Console.Write(string.Join(" ", BynarySystem(number)));