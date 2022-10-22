/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 89, 6] -> 85
*/

void FillArray(int[] collection) //заполнение массива случайными числами.
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

int GetNotEvenArray (int[] col) // сумма нечетных значений
{
    int sum = 0;
    for (int pos = 0; pos < col.Length; pos++)
    {
        while (pos % 2 != 0)
        {
            sum += col[pos];
        }
    }
    return sum;
}

void PrintArray(int[] col, int sum) //печать массива и суммы.
{
    int count = col.Length;
    int position = 0;
    int noteven = sum;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[3]);
    Console.Write("] -> " + sum);
}

int[] array = new int[4]; //задание массива из 4 эл-тов.
int sum = GetNotEvenArray (array);
FillArray(array);
PrintArray(array, sum);
Console.WriteLine();