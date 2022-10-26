// Составить частотный словарь элементов двумерного массива

void FillArray(out int[,] newArray)
{
    newArray = new int[15, 10];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(1, 21);
        }
    }
}

void PrintArray(int[,] mass)
{
    for (int col = 0; col < mass.GetLength(0); col++)
    {
        for (int pow = 0; pow < mass.GetLength(1); pow++)
        {
            Console.Write(mass[col, pow] + "\t");
        }
        Console.WriteLine();
    }
}

void CountChar(int[,] arr)
{
    int[] emptyArray = new int[21];
    int index = 0;

    foreach (int num in arr)
    {
        if(!emptyArray.Contains(num))
        {

        }
    }
}

// не решил