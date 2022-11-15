// поворот на 90 градусов двумерного массива

int[,] Rotate(int[,] source)
{
    int rows = source.GetLength(0);
    int columns = source.GetLength(1);
    int[,] res = new int[rows, columns];


    for (int j = 0; j < rows; j++)
    {
        for (int i = 0; i < columns; i++)
        {
            res[i, rows - 1 - j] = source[j, i];
        }
    }
    return res;
}


void Print(int[,] source)
{
    int rows = source.GetLength(0);
    int columns = source.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{source[i, j], 2}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ar1 = {{1, 2, 3},
           {4, 5, 6},
           {7, 8, 9}};

Print(ar1);
var ar2 = Rotate(ar1);
Print(ar2);