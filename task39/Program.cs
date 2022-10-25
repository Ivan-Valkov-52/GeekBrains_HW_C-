// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int ImputNomber()
{
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
        Console.Write("Введите корректное значение: ");
    return num;
}

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i] + "]");
            break;
        }
        Console.Write(array[i] + ", ");
    }
}

// int[] ReversArray(int[] array)
// {
//     int[] res = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         res[i] = array[array.Length - 1 - i];
//     }
//     return res;
// }

void ReversArray(int[] array)
{
    int tmp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = ImputNomber();
int[] array = GetArray(size, -5, 5);
PrintArray(array);
Console.Write(" -> ");
ReversArray(array);
PrintArray(array);
