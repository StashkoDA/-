// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] tabl) // заполняем массив случайными числами из полуинтервала (1, 100]
{
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i, j] = new Random().Next(1, 100); // заполняем массив случайными числами из полуинтервала (1, 100]
        }
    }
}

int GetIndex(string text) // функция запроса ввода индекса
{
    Console.Write(text + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetNumb(int[,] tabl) // создаём одномерный массив из эл-тов 2мерного массива tabl
{
    int[] result = new int[tabl.GetLength(0) * tabl.GetLength(1)]; // создаём одномерный массив из эл-тов 2мерного массива tabl 
                                                                   // длина массива равна кол-ву эл-тов 2мерного массива tabl
    int i = 0;
    for (int j = 0; j < tabl.GetLength(0); j++) // перебираем строки
    {
        for (int q = 0; q < tabl.GetLength(1); q++)
        {
            if(i < result.Length)
            {
                result[i] = tabl[j, q];
            }
            i++;
        }           
    }
    return result;
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
void PrintNumb(int[] result, int numb) // печать искомого эл-та
{
    if(numb >= 0 && numb < 16)
    {
        for(int i = 0; i < result.Length; i++)
        {
            if(i == numb) Console.WriteLine(numb + " -> " + result[i]);
        }
    }
    else Console.WriteLine(numb + " -> Такой позиции в масcиве нет. Введите число от 0 до 15");
}

Console.WriteLine(); 


int[,] tablic = new int[4, 4];
FillArray(tablic);
PrintArray(tablic);
int numb = GetIndex("Введите позицию элемента от 0 до 15"); // запрос ввода индекса
int[] trans = GetNumb(tablic);
PrintNumb(trans, numb);
