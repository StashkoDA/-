/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// Решение с созданием произвольного массива

void FillArray(int[] collection) //ф-ция ввода данных массива без вывода значений.
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 999);
    }
}

int GetEvenArray (int[] col)
{
    int sum = 0;
    for (int pos = 0; pos < col.Length; pos++)
    {
        while (col[pos] % 2 == 0)
        {
            sum +=1;
        }
    }
    return sum;
}

void PrintArray(int[] col, int sum) //печать массива.
{
    int count = col.Length;
    int position = 0;
    int even = sum;
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
int sum = GetEvenArray (array);
FillArray(array);
PrintArray(array, sum);
Console.WriteLine();
