
int ImputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Ввели не корректное значение! Попробуйте ещё раз: ");
    return num;
}

double ExponentNumber(int numA, int numB)
{
    double result = 1;
    if (numB > 0)
    {
        for (int index = 0; index < numB; index++)
        {
            result *= numA;
        }
    }
    else
    {
        for (int index = 0; index > numB; index--){
            result *= numA;
        }
        result = 1 / result;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int numberA = ImputNumber();
Console.Write("Введите степень числа: ");
int numberB = ImputNumber();
Console.WriteLine($"{numberA}, в степени {numberB} = {ExponentNumber(numberA, numberB)}");
