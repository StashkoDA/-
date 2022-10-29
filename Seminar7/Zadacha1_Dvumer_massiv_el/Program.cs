// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

    int sum = tabl.GetLength(0) * tabl.GetLength(1);
    Console.Write($"{sum}");
    Console.WriteLine();
    
}

int[,] tablic = new int[4, 4];
Console.WriteLine(); // введено для создания пустой строки между матрицами
FillArray(tablic);
PrintArray(tablic);
