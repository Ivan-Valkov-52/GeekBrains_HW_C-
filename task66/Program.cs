// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int m, int n)
{
    if(m < n)
    {
        return m + SumNaturalNumbers(m + 1, n);
    } else {
        return m;
    }
}

Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.Write("Введите второе число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {numberM}; N = {numberN} -> " + SumNaturalNumbers(numberM, numberN));
Console.Write("Для выхода из программы введите любую клавишу...");
Console.ReadKey();