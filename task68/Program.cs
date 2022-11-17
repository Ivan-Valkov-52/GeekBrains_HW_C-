// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int number1, int number2)
{
    if(number1 == 0)
    {
        return number2 + 1;
    } else if (number1 > 0 && number2 == 0)
    {
        return AckermanFunction(number1 - 1, 1);
    } else if (number1 > 0 && number2 > 0)
    {
        return AckermanFunction(number1 - 1, AckermanFunction(number1, number2 -1));
    } else
    {
        return number2;
    }
}

Console.Write("Введите первое неотрицательное число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {number1}; N = {number2} -> A({number1},{number2}) = " + AckermanFunction(number1, number2));
Console.ReadKey();
