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

int GetIndex(string text) // функция запроса ввода индекса
{
    Console.Write(text + ": ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GetNumb(int[,] tabl, int numb) // поиск элемента в массиве
{
    if (numb >= 0 && numb < 16)
    {
        for (int i = 0; i < tabl.GetLength(0); i++)
            {
                for (int j = 0; j < tabl.GetLength(1); j++)
                {
                    int sum = 0;
                    if(sum == numb)
                    {
                        return tabl[i, j];
                        //break;
                    }
                    else sum++;
                }
            }
    }
    else return -1;
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
void PrintNumb(int numb, int el)
{
    Console.Write(numb + " -> " + el);
    Console.WriteLine();
}


    /*if (value >= 0 && value < 17)
        {
            q = value;
            Console.Write(q + " -> " + tabl[i, j]);
        }
    else Console.Write("Такой позиции в масиве нет. Введите число от 0 до 15");
    */


int numb = GetIndex("Введите позицию элемента от 0 до 15"); // запрос ввода индекса
int[,] tablic = new int[4, 4];
FillArray(tablic);
int el = GetNumb(tablic, numb);
PrintArray(tablic);
PrintNumb(numb, el);

