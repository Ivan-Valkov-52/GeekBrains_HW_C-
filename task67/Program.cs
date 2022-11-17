// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите корректное значение");
    return num;
}

int SumDigitsNumbers(int num, int value)
{
    if (num <= 0)
    {
        return value;
    }
    else
    {
        return SumDigitsNumbers(num / 10, value += num % 10);
    }
}

Console.Write("Введите любое число N: ");
int number = InputNumber();
Console.Write($"Сумма цифр числа {number} = ");
int sum = 0;
Console.WriteLine(SumDigitsNumbers(number, sum));
