// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.Write("Введите любое целое число: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
    Console.Write("Не верное значение! Попробуйте ещё раз: ");
Console.Write(number + " -> ");
for (int index = 1; index <= number; index++)
{
    if (index == number)
    {
        Console.Write(index * index);
        break;
    }
    Console.Write(index * index + ", ");
}
