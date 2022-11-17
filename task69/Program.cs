// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputNumber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.WriteLine("Введите корректное значение");
    return num;
}

int ExponentNumber(int number, int exp)
{
    if (exp == 0)
    {
        return 1;
    }
    else
    {
        return number * ExponentNumber(number, exp - 1);
    }

}

Console.Write("Введите число N: ");
int number = InputNumber();
Console.Write("Введите степень числа N: ");
int degree = InputNumber();
Console.WriteLine($"Число {number} в степени {degree} -> " + ExponentNumber(number, degree));