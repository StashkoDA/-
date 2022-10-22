/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillArray(double[] collection) //заполнение массива случайными числами.
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index] = new Random().Next(1, 100);
    }
}

double GetDiffnArray (double[] col) // поиск разницы между макс и мин
{
   double min = col[0];
   double max = col[0];
   for (int pos = 1; pos < col.Length; pos++)
    {
        if (col[pos] > max) max = col[pos];
        if (col[pos] < min) min = col[pos];
    }
    return max - min;
}

void PrintArray(double[] col, double diff) //печать массива.
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write(col[position] + ", ");
    }
    Console.Write(col[3] + "] -> " + diff);
}

double[] array = new double[4]; //задание массива из 4 эл-тов.
FillArray(array);
double diff = GetDiffnArray (array);
PrintArray(array, diff);
Console.WriteLine();
