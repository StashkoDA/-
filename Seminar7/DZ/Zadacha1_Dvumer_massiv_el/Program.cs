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

void GetNumb(int[,] tabl, int numb) // поиск элемента в массиве
{
    int[] result = new int[tabl.GetLength(0) * tabl.GetLength(1)]; // создаём одномерный массив из эл-тов 2мерного массива tabl 
    // длина массива равна кол-ву эл-тов 2мерного массива tabl
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < tabl.GetLength(0); j++) // перебираем строки
        {
            for (int q = 0; q < tabl.GetLength(1); q++)
            {
                result[i] = tabl[j, q]; // получаем новый массив
            }
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
void PrintNumb(int[,] tabl, int numb) // печать искомого эл-та
{
    int[] result = new int[tabl.GetLength(0) * tabl.GetLength(1)]; // создаём одномерный массив из эл-тов 2мерного массива tabl 
    // длина массива равна кол-ву эл-тов 2мерного массива tabl
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = 0; j < tabl.GetLength(0); j++) // перебираем строки
        {
            for (int q = 0; q < tabl.GetLength(1); q++)
            {
                if(i == numb)
                {
                    result[i] = tabl[j, q]; // получаем новый массив
                    Console.WriteLine(" -> " + result[numb]);
                }
                else Console.WriteLine(numb + " -> Такой позиции в масиве нет. Введите число от 0 до 15");
            }
        }
    }
        
    Console.WriteLine();
}

int numb = GetIndex("Введите позицию элемента от 0 до 15"); // запрос ввода индекса
int[,] tablic = new int[4, 4];
FillArray(tablic);
GetNumb(tablic, numb);
PrintArray(tablic);
PrintNumb(tablic, numb);


