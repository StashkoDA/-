/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr1, int[,] matr2)
{
    int i = 0; int k = 0;
    while (i < matr1.GetLength(0))
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            Console.Write($"{matr1[i, j]} ");
        }
        Console.Write(" | ");
        for (int q = 0; q < matr2.GetLength(1); q++)
        {
            Console.Write($"{matr2[k, q]} ");
        }
        Console.WriteLine();
        i++; k++;
    }
}

void PrintMatrMult(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrMult(int[,] matr1, int[,] matr2) // метод умножения матриц
{                                               // далее брал кол-во строк и столбцов из разных матриц, но это не важно, если они квадратные
    int[,] res = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            res[i, j] = 0;
            for (int q = 0; q < matr1.GetLength(1); q++)
            {
                res[i, j] += matr1[i, q] * matr2[q, j];
            }
        }
    }
    return res;
}

Console.WriteLine("Даны две матрицы:");
int[,] matr1 = new int[2, 2];
int[,] matr2 = new int[2, 2];
FillMatrix(matr1);
FillMatrix(matr2);
PrintMatrix(matr1, matr2);
int[,] matr3 = GetMatrMult(matr1, matr2);
Console.WriteLine("Произведение матриц:");
PrintMatrMult(matr3);