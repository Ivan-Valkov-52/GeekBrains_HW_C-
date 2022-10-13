// Напишите программу, которая принимает на вход число А и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int number)
{
    int result = 0;
    for (int index = 1; index <= number; index++)
    {
        result = result + index;
    }
    return result;
}

Console.Clear();
Console.Write("Введите любое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Введите корректное значение: ");
Console.WriteLine(number + " -> " + SumNumbers(number));