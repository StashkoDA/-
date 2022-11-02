/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

void FillArray(int[,] tabl)
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i, j] = new Random().Next(1, 100); // заполняем массив случайными числами из полуинтервала (1, 100]
        }
    }
}

void PrintArray(int[,] tabl) // печать полученного массива
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"{tabl[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] SrArifm(int[,] tabl)
{
    double[] result = new double[tabl.GetLength(1)]; // создаём одномерный массив из сред арефм-х по каждому столбцу 
    // длина массива равна кол-ву столбцов
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0; // задаём переменную суммы эл-тов в столбце
        for (int j = 0; j < tabl.GetLength(0); j++) // перебираем элементы в столбце
        {
            result[i] += tabl[j, i]; // определяем сумму эл-тов в столбце
        }
        result[i] /= tabl.GetLength(0); // делим сумму на кол-во эл-тов в столбце
    }
    return result; // получаем результирующий массив из средн арефм по столбцам
}

void PrintRez(int[,] tabl)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double[] result = new double[tabl.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0; // задаём переменную суммы эл-тов в столбце
        for (int j = 0; j < tabl.GetLength(0); j++) // перебираем элементы в столбце
        {
            result[i] += tabl[j, i]; // определяем сумму эл-тов в столбце
        }
        result[i] /= tabl.GetLength(0);
        Console.Write($"{result[i]} | ");
    }
    Console.WriteLine();
}

int[,] tablic = new int[4, 5];
FillArray(tablic);
PrintArray(tablic);
double[] rez = SrArifm(tablic);
PrintRez(tablic);