/*
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNumb(string text)
{
    Console.Write(text);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int GetSumNaturalNumbers(int numb1, int numb2)
{
    int sum = 0;
    while (numb1 <= numb2)
    {
        sum += numb1;
        numb1++;
    }
    return sum;
}

void PrintResult(int m, int n, int sum)
{
    Console.Write("M = " + m + ", N = " + n + " -> " + sum);
    Console.WriteLine();
}

int m = GetNumb("Введите значение M: ");
int n = GetNumb("Введите значение N: ");
int sum = GetSumNaturalNumbers(m, n);
PrintResult(m, n, sum);