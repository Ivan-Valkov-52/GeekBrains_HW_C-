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

int SumDigitsNumbers(int num)
{
    if (num <= 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + SumDigitsNumbers(num/10);
    }
}

Console.Write("Введите любое число N: ");
int number = InputNumber();
Console.Write($"Сумма цифр числа {number} = ");
Console.WriteLine(SumDigitsNumbers(number));
Console.ReadKey();
