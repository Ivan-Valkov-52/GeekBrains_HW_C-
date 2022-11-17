// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

void EvenNumbers(int num)
{
    if(num == 1)
    {
        return;
    } else
    {
        if(num % 2 == 0)
        {
            if(num == 2)
            {
                Console.Write(num);
            } else
            {
                Console.Write(num + ", ");
            }
        }
        EvenNumbers(num - 1);
    }
}

Console.Clear();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
Console.Write($"N = {number} -> ");
EvenNumbers(number);
Console.ReadKey();