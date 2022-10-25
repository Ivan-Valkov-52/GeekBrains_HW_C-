// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CloneArray(int[] array)
{
    int[] clone = new int[array.Length];
    for (int i = 0; i < clone.Length; i++){
        clone[i] = array[i];
    }
    return clone;
}

Console.Clear();
int[] array = { -4, 5, 6, 8, 7, 25, -4, 65, 78 };
Console.Write("Заданный массив [");
Console.Write(string.Join(", ", array));
Console.WriteLine("]");
int[] arrayClone = CloneArray(array);
Console.Write("Клонированный массив [");
Console.Write(string.Join(", ", arrayClone));
Console.WriteLine("]");
