// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

int ImputNomber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

void GetTriangle(int sideA, int sideB, int sideC)
{
    if (sideA < sideB + sideC)
    {
        if (sideB < sideA + sideC)
        {
            if (sideC < sideA + sideB)
            {
                Console.Write($"Треугольник ABC({sideA},{sideB},{sideC}) - существует!");
            }
            else
            {
                Console.Write($"Треугольник ABC({sideA},{sideB},{sideC}) - не существует!");
            }
        }
        else
        {
            Console.Write($"Треугольник ABC({sideA},{sideB},{sideC}) - не существует!");
        }
    }
    else
    {
        Console.Write($"Треугольник ABC({sideA},{sideB},{sideC}) - не существует!");
    }
}

Console.Clear();
Console.Write("Введите длину стороны А треукольника АBC: ");
int sideA = ImputNomber();
Console.Write("Введите длину стороны B треукольника АBC: ");
int sideB = ImputNomber();
Console.Write("Введите длину стороны C треукольника АBC: ");
int sideC = ImputNomber();
GetTriangle(sideA, sideB, sideC);
