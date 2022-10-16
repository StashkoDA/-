// Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение с созданием произвольного массива
/*
void FillArray(int[] collection) //ф-ция ввода данных массива без вывода значений.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100); // заполняем массив случайными числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col) //печать массива.
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[8]);
    Console.Write("]");
}

int[] array = new int[9]; //задание массива из 10 эл-тов.
FillArray(array);
PrintArray(array);
Console.WriteLine();
*/

// Решение с выводом на экран массива-константы
/*
void PrintArray(int[] col) //печать массива.
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[8]);
    Console.Write("]");
}

int[] array = new int[9] {1, 3, 6, 8, 9, 2, 44, 77, 46}; //задание массива из 10 эл-тов.
//FillArray(array);
PrintArray(array);
Console.WriteLine();
*/

// Решение с заданием массива вручную

void FillArray(int[] collection) //ф-ция ввода данных массива без вывода значений.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("Введите элемент массива: ");
               
        collection[index] = Convert.ToInt32(Console.ReadLine());; // заполняем массив вручную
        index++;
    }
}

void PrintArray(int[] col) //печать массива.
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.Write(col[8]);
    Console.Write("]");
}

try
    {
        int[] array = new int[9]; //задание массива из 9 эл-тов.

        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
    }
catch
    {
        Console.WriteLine("Надо было ввести целое число");
    }