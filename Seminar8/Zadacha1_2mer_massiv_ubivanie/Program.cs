/* Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

void FillArray(int[,] free)
{
    for (int i = 0; i < free.GetLength(0); i++)
    {
        for (int j = 0; j < free.GetLength(1); j++)
        {
            free[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] free)
{
    for (int i = 0; i < free.GetLength(0); i++)
    {
        for (int j = 0; j < free.GetLength(1); j++)
        {
            Console.Write($"{free[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

void GetOrderedArray(int[,] free) // получение упорядоченного массива
{
    int[,] res = new int[free.GetLength(0), free.GetLength(1)];
    for (int i = 0; i < free.GetLength(0); i++)
    {
        for (int j = 0; j < free.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < free.GetLength(1); k++)
            {
                if (free[i, k] < free[i, minPosition]) minPosition = k;
            }


            int box = free[i, j];           // производим замену элементов далее
            free[i, j] = free[i, minPosition];
            free[i, minPosition] = box;
        }
        
    }
    
}

Console.WriteLine("Задан произвольный массив:");
int[,] arbitraryArray = new int[4, 3];
FillArray(arbitraryArray);
PrintArray(arbitraryArray);
Console.WriteLine("получение упорядоченного массива:");
GetOrderedArray(arbitraryArray);
PrintArray(arbitraryArray);
