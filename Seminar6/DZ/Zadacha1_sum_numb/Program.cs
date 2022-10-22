/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void FillArray(int[] col) //ф-ция ввода данных массива без вывода значений.
{
    //Console.Write("Введите количество элементов массива: ");
    //M = Convert.ToInt32(Console.ReadLine());
    int length = col.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите элемент массива: ");
               
        col[index] = Convert.ToInt32(Console.ReadLine()); // заполняем массив вручную
        index++;
    }
}

int GetPositiveArray (int[] col) // количество числе > 0
{
    int sum = 0;
    for (int pos = 0; pos < col.Length; pos++)
    {
        if (col[pos] > 0) sum +=1;
    }
    return sum;
}

void PrintArray (int[] col, int sum, int M) //печать массива.
{
    Console.Write("[");
    for (int position = 0; position < col.Length - 1; position++)
    {
        Console.Write(col[position] + ", ");
    }
    Console.Write(col[M-1] + "] -> " + sum);
}
int M;
Console.Write("Введите количество элементов массива: ");
M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M]; //задание массива из 4 эл-тов.
FillArray(array);
int sum = GetPositiveArray (array);
PrintArray(array, sum, M);
Console.WriteLine();