/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(double[] collection) //ф-ция ввода данных массива без вывода значений.
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

double GetDiffnArray (double[] col) // поиск разницы между макс и мин
{
   double min = col(0);
   double max = col(0);
   for (int pos = 1; pos < col.Length; pos++)
    {
        if (col(pos) > max) max = col(pos);
        if (col(pos) < min) min = col(pos);
    }
    return max - min;
}

void PrintArray(double[] col, double diff) //печать массива.
{
    int count = col.Length;
    int position = 0;
    double even = diff;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[3]);
    Console.Write("] -> " + even);
}

double[] array = new double[4]; //задание массива из 4 эл-тов.
double diff = GetDiffnArray (array);
FillArray(array);
PrintArray(array, diff);
Console.WriteLine();
