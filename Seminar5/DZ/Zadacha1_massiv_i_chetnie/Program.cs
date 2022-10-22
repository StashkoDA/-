/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void FillArray(int[] collection) //заполнение массива случайными числами.
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
    }
}

int GetEvenArray (int[] col) // количество чётных
{
    int sum = 0;
    for (int pos = 0; pos < col.Length; pos++)
    {
        if (col[pos] % 2 == 0) sum +=1;
    }
    return sum;
}

void PrintArray(int[] col, int sum) //печать массива.
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write(col[position] + ", ");
    }
    Console.Write(col[3] + "] -> " + sum);
}

int[] array = new int[4]; //задание массива из 4 эл-тов.
FillArray(array);
int sum = GetEvenArray (array);
PrintArray(array, sum);
Console.WriteLine();
