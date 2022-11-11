/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetMinString(int[,] arr) // получение одномерного массива из сумм эл-тов в строках
{
    int[] result = new int[arr.GetLength(0)];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] += arr[i, j];
        }
    }
    return result;
}

void PrintMinString(int[] arrSum)
{
    int minPosition = 0;
    for (int i = 0; i < arrSum.Length - 1; i++)
    {        
        for (int j = i + 1; j < arrSum.Length; j++)
        {
            if (arrSum[j] < arrSum[minPosition]) minPosition = j;
            
        }
    }
    Console.WriteLine($"Строка с минимальной суммой элементов: {minPosition + 1} строка");
}


Console.WriteLine("Задан произвольный массив:");
int[,] arbitraryArray = new int[3, 3];
FillArray(arbitraryArray);
PrintArray(arbitraryArray);
//int[] sum = new int[4];
int[] resultSum = GetMinString(arbitraryArray);
PrintMinString(resultSum);
