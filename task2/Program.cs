// Мой первый вариант
// string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
// bool text = true;
// while (text)
// {
//     int numberDay = int.Parse(Console.ReadLine());
//     if (1 <= numberDay && numberDay <= 7)
//     {
//         Console.WriteLine("День недели: " + day[numberDay - 1]);
//         text = false;
//     }
//     else
//     {
//         Console.WriteLine("Ввели неверное число, попробуйте снова!");
//     }
// }


// Попробовать второй вариант с switch
Console.Clear();
Console.Write("Введите день недели: ");
int numberDay = int.Parse(Console.ReadLine());
switch (numberDay)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница, развратница!");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Введено не корректное значение!");
        break;
}

